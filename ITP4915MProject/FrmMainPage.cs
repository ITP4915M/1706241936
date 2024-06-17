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
    public partial class FrmMainPage : Form
    {
        public Point mouseLocation;
        private Point mouseOffset;
        
        bool panelLeftExpand; 
        bool salesCollapsed;
        bool inventoryCollapsed;
        public FrmMainPage()
        {
            InitializeComponent();
            panelLefttimer.Start(); //一開畫面就行
            timerTime.Start(); //一開畫面就顯示時間
            salseTimer.Start();
            inventoryTimer.Start();


        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString(); //show time
            Lbl_Data.Text = DateTime.Now.ToLongDateString(); //show date
        }

        private void button2_Click(object sender, EventArgs e) //三條線
        {
            panelLefttimer.Start(); //撳落去彈出黎
        }

        


        private void button1_Click(object sender, EventArgs e)
        {
          
            this.Close(); //右上角交
            
            Application.ExitThread();
        }


        public void loadform(object Form)
        {
            if (this.panMain.Controls.Count > 0)
            {
                this.panMain.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panMain.Controls.Add(f);
            this.panMain.Tag = f;
            f.Show();


        }





      



        private void btn_OrderList_Click(object sender, EventArgs e)
        {
            loadform(new FrmOrderList());
        }

        private void btn_CreateOrder_Click(object sender, EventArgs e)
        {
            loadform(new FrmCreateOrder());
        }

        private void mouse_Down(object sender, MouseEventArgs e)
        {
            mouseOffset = new Point(e.X, e.Y);
        }
        private void mouse_Move(object sender, MouseEventArgs e)  //mouse hold the top bar can move
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = new Point(e.X - mouseOffset.X, e.Y - mouseOffset.Y);
                Location = PointToScreen(newLocation);
            }
        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            loadform(new FrmStaffManagment());
        }


        private void panelLeftTimer_Tick(object sender, EventArgs e)
        {
            if (panelLeftExpand)
            {
                panelLeft.Width -= 10; //if panelLeft is expand, minimize
                if (panelLeft.Width == panelLeft.MinimumSize.Width)
                {
                    panelLeftExpand = false;
                    panelLefttimer.Stop();
                }
            }
            else
            {
                panelLeft.Width += 10; //if panelLeft is expand, maximum
                if (panelLeft.Width == panelLeft.MaximumSize.Width)
                {
                    panelLeftExpand = true;
                    panelLefttimer.Stop();
                }
            }
        }

        private void containerSales_Tick(object sender, EventArgs e) //sales container controller
        {
            
                if (salesCollapsed)
                {
                    ContainerSales.Height += 180;
                    if (ContainerSales.Height == ContainerSales.MaximumSize.Height) 
                    salesCollapsed = false;
                    salseTimer.Stop();
                }
                else
                {
                    ContainerSales.Height -= 180;
                    if (ContainerSales.Height == ContainerSales.MinimumSize.Height) 
                    salesCollapsed = true;
                    salseTimer.Stop();
                }
            
        }

        private void btn_SalesManagement_Click(object sender, EventArgs e)
        {
            salseTimer.Start();//撳落去sales container彈出黎
        }

        private void containerInventory_Tick(object sender, EventArgs e)
        {
            if (inventoryCollapsed)
            {
                ContainorInventory.Height += 225;
                if (ContainorInventory.Height == ContainorInventory.MaximumSize.Height)
                    inventoryCollapsed = false;
                inventoryTimer.Stop();
            }
            else
            {
                ContainerSales.Height -= 225;
                if (ContainorInventory.Height == ContainorInventory.MinimumSize.Height)
                    inventoryCollapsed = true;
                inventoryTimer.Stop();
            }
        }

        private void InventoryManagement_Click(object sender, EventArgs e)
        {
            inventoryTimer.Start();//撳落去Inventory container彈出黎
        }
    }
}