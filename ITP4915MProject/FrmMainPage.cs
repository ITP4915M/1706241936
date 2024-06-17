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
        int panelWidth;
        bool isCollapsed;
        bool orderCollasped;
        public FrmMainPage()
        {
            InitializeComponent();
            timerTime.Start();
            panelWidth = panelLeft.Width;
            isCollapsed = false;

        }

        private void timer1_Tick(object sender, EventArgs e) //panelLeft control
        {
            if (isCollapsed)
            {
                // if panelleft is expand , minimize
                panelLeft.Width += 10;
                if (panelLeft.Width >= panelWidth)
                {
                    Slidetimer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width -= 10;
                if (panelLeft.Width <= 55)
                {
                    Slidetimer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void timerTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString(); //show time
            Lbl_Data.Text = DateTime.Now.ToLongDateString(); //show date
        }

        private void button2_Click(object sender, EventArgs e) //三條線
        {
            Slidetimer1.Start(); //撳落去彈出黎
        }

        private void btnOrder_Click(object sender, EventArgs e)

        {
            SalseTimer.Start();
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



        private void HomeTimer_Tick(object sender, EventArgs e)
        {
            ContainerCollection();
        }

        private void ContainerCollection()
        {
            if (orderCollasped)
            {
                ContainerSales.Height += 180;
                if (ContainerSales.Height == ContainerSales.MaximumSize.Height) ;
                orderCollasped = false;
                SalseTimer.Stop();
            }
            else
            {
                ContainerSales.Height -= 180;
                if (ContainerSales.Height == ContainerSales.MinimumSize.Height) ;
                orderCollasped = true;
                SalseTimer.Stop();
            }
        }

        private void btnItemManagment_Click(object sender, EventArgs e)
        {
            loadform(new FrmItemList());
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
        private void mouse_Move(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = new Point(e.X - mouseOffset.X, e.Y - mouseOffset.Y);
                Location = PointToScreen(newLocation);
            }
        }

        private void btnFrmItem_Click(object sender, EventArgs e)
        {
            loadform(new FrmItemList());
        }

        private void btnStockRecord_Click(object sender, EventArgs e)
        {
            loadform(new FrmDispatchNoteList());
        }

        private void btnWorks_Click(object sender, EventArgs e)
        {

        }

        private void btn_Account_Click(object sender, EventArgs e)
        {
            loadform(new FrmStaffManagment());
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            loadform(new FrmStockRecord());
        }

        private void containerSales_Click(object sender, EventArgs e)
        {

        }
    }
}