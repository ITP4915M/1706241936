using BLL;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITP4915MProject
{
    public delegate void DelBindSelectedItem(List<ItemInfo> selectedItems);
    public partial class FrmCreateOrder : Form
    {
        List<ItemInfo> currentItems = new List<ItemInfo>();
        DelBindSelectedItem delitemSelected;
        DISetBLL disetBLL = new DISetBLL();
        public FrmCreateOrder()
        {
            InitializeComponent();
            dgvOrderItem.CellValidating += new DataGridViewCellValidatingEventHandler(dgvOrderItem_CellValidating);
        }

        /// <summary>
        /// click to select item
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            FrmOrderAddItem frmOrderAddItem = new FrmOrderAddItem(delitemSelected, currentItems);
            frmOrderAddItem.ShowDialog();

        }


        /// <summary>
        /// bind the selected item into create orde data grid view
        /// </summary>
        /// <param name="itemInfos"></param>
        public void BindSelectedItem(List<ItemInfo> itemInfos)
        {

            currentItems = itemInfos;

            //create a col to let user enter an amount of selected item
            dgvOrderItem.DataSource = itemInfos;
            DataGridViewTextBoxColumn amountColumn = new DataGridViewTextBoxColumn();
            amountColumn.Name = "Amount";
            amountColumn.HeaderText = "Amount";
            amountColumn.ValueType = typeof(int); // set the type to integer
            amountColumn.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // set content in center
            amountColumn.Width = 60; // set width
            dgvOrderItem.Columns.Add(amountColumn);

            // default value 1
            foreach (DataGridViewRow row in dgvOrderItem.Rows)
            {
                row.Cells["Amount"].Value = 1;
            }
/*            //add the selection box col in the datagrid view
            DataGridViewCheckBoxColumn chkBoxColumn = new DataGridViewCheckBoxColumn();
            chkBoxColumn.HeaderText = "Select";
            chkBoxColumn.Width = 30;
            chkBoxColumn.Name = "chkBoxColumn";
            dgvOrderItem.Columns.Insert(0, chkBoxColumn);*/

        }


        /// <summary>
        /// initialize the create order form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCreateOrder_Load(object sender, EventArgs e)
        {
            //binding dealer combobox
            DealerBLL dealerBLL = new DealerBLL();
            List<Dealer> dealers = dealerBLL.getAllDealer();

            dealers.Insert(0, new Dealer { DealerID = "--Select Dealer--", DealerName = "--Select Dealer--" });
            cbxDealer.DataSource = dealers;
            cbxDealer.DisplayMember = "DealerName";
            cbxDealer.ValueMember = "DealerID";

            //set the column size
            dgvOrderItem.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            //assign the delegate method 
            delitemSelected = BindSelectedItem;

        }

        /// <summary>
        /// validate the amount of selected item by the user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvOrderItem_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {

            if (dgvOrderItem.Columns[e.ColumnIndex].Name == "Amount")
            {
                int newQuantity;

                if (!int.TryParse(e.FormattedValue.ToString(), out newQuantity))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter validate amount");
                }
                else
                {

                    int stock = Convert.ToInt32(dgvOrderItem.Rows[e.RowIndex].Cells["Quantity"].Value);
                    if (newQuantity < 0 || newQuantity > stock)
                    {
                        e.Cancel = true;
                        MessageBox.Show($"enter amount must less than inventory quantity {stock}.");
                    }
                }
            }
        }

        /// <summary>
        /// create the order to pending status
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cbxDealer.SelectedValue == null || cbxDealer.SelectedValue.ToString() == "--Select Dealer--")
            {
                MessageBox.Show("Please Selcect a dealer first", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (dgvOrderItem.Rows.Count == 0)
            {
                MessageBox.Show("Please Selcect an Item", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int totalQuantity = 0;
                decimal totalPrice = 0m;

                foreach (DataGridViewRow row in dgvOrderItem.Rows)
                {
                    // get the amount value
                    int quantity = 0;
                    if (row.Cells["Amount"].Value != null)
                    {
                        quantity = Convert.ToInt32(row.Cells["Amount"].Value);
                    }

                    // get the price value
                    decimal price = 0m;
                    if (row.Cells["Price"].Value != null)
                    {
                        price = Convert.ToDecimal(row.Cells["Price"].Value);
                    }

                    //count the total quantity
                    totalQuantity += quantity;
                    totalPrice += quantity * price; // calculate the totalprice
                }
                OrderBLL orderBLL = new OrderBLL();
                Order newPendingOrder = new Order();
                newPendingOrder.OrderDate = DateTime.Now;
                newPendingOrder.DealerID = cbxDealer.SelectedValue.ToString();
                newPendingOrder.Status = "Pending";
                newPendingOrder.StaffID = GlobalVariables.StaffID;
                newPendingOrder.TotalItem = totalQuantity;
                newPendingOrder.OrderAmounts = totalPrice;
                newPendingOrder.Description = rtbRemark.Text;

                DialogResult result = MessageBox.Show("Are you sure to save and create an order?", "confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


                if (result == DialogResult.Yes)
                {
                    //create order
                    string orderid = orderBLL.addOrderReturnID(newPendingOrder);

                    //create disets
                    List<DISet> dISets = new List<DISet>();
                    foreach (DataGridViewRow row in dgvOrderItem.Rows)
                    {
                        if (row.IsNewRow) continue;

                        DISet diset = new DISet();
                        diset.ItemID = row.Cells["ItemID"].Value.ToString();
                        diset.Quantity = Convert.ToInt32(row.Cells["Amount"].Value);
                        diset.OrderID = orderid;
                        diset.Remark = rtbRemark.Text;
                        dISets.Add(diset);
                        
                    }
                    disetBLL.addDISets(dISets);


                    if (orderid != null){
                        MessageBox.Show("Create Order Successful");
                            //cleare the current item list info
                            currentItems.Clear();

                            // bind  DataGridView by default
                            dgvOrderItem.DataSource = null;
                            dgvOrderItem.DataSource = currentItems;

                            // set default ComboBox
                            cbxDealer.SelectedIndex = 0;
                     }else{
                        MessageBox.Show("Can not create order");
                    }
 
                }
                else
                {
                    MessageBox.Show(" cancel", "Action cancel", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        /// <summary>
        /// create the order to draft stauts
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_SaveToDraft_Click_1(object sender, EventArgs e)
        {
            if (cbxDealer.SelectedValue.ToString() == "--Select Dealer--")
            {
                MessageBox.Show("Please Selcect a dealer first", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } else if (dgvOrderItem.Rows.Count == 0) {
                MessageBox.Show("Please Selcect an Item", "tips", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                int totalQuantity = 0;
                decimal totalPrice = 0m;

                foreach (DataGridViewRow row in dgvOrderItem.Rows)
                {
                    // get the amount value
                    int quantity = 0;
                    if (row.Cells["Amount"].Value != null)
                    {
                        quantity = Convert.ToInt32(row.Cells["Amount"].Value);
                    }

                    // get the price value
                    decimal price = 0m;
                    if (row.Cells["Price"].Value != null)
                    {
                        price = Convert.ToDecimal(row.Cells["Price"].Value);
                    }

                    
                    totalQuantity += quantity;  // count the total quantity
                    totalPrice += quantity * price; // count the total price
                }

                //create order 
                OrderBLL orderBLL = new OrderBLL();
                Order newDraftOrder = new Order();
                newDraftOrder.OrderDate = DateTime.Now;
                newDraftOrder.DealerID = cbxDealer.SelectedValue.ToString();
                newDraftOrder.Status = "Draft";
                newDraftOrder.StaffID = GlobalVariables.StaffID;
                newDraftOrder.TotalItem = totalQuantity;
                newDraftOrder.OrderAmounts = totalPrice;
                newDraftOrder.Description = rtbRemark.Text;

                string orderid = orderBLL.addOrderReturnID(newDraftOrder);

                //create disets
                List<DISet> dISets = new List<DISet>();
                foreach (DataGridViewRow row in dgvOrderItem.Rows)
                {
                    if (row.IsNewRow) continue;

                    DISet diset = new DISet();
                    diset.ItemID = row.Cells["ItemID"].Value.ToString();
                    diset.Quantity = Convert.ToInt32(row.Cells["Amount"].Value);
                    diset.OrderID = orderid;
                    diset.Remark = rtbRemark.Text;
                    dISets.Add(diset);
                }
                disetBLL.addDISets(dISets);


                if (orderid !=null)
                {
                    MessageBox.Show("Draft Successful");
                    //cleare the current item list info
                    currentItems.Clear();

                    // bind  DataGridView by default
                    dgvOrderItem.DataSource = null;
                    dgvOrderItem.DataSource = currentItems;

                    // set default ComboBox
                    cbxDealer.SelectedIndex = 0;

                    // set default ComboBox
                    cbxDealer.SelectedIndex = 0; 

                }
                else
                {
                    MessageBox.Show("Can not Save to Draft");
                }



            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpItem_Enter(object sender, EventArgs e)
        {

        }

        private void dgvOrderItem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpInformation_Enter(object sender, EventArgs e)
        {

        }

        private void rtbRemark_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxDealer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblDealer_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
