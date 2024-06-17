
namespace ITP4915MProject
{
    partial class FrmOrderDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderDetail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpOrderItem = new System.Windows.Forms.GroupBox();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.grpOrderInfo = new System.Windows.Forms.GroupBox();
            this.txtOrderDate = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.grpDealerInfo = new System.Windows.Forms.GroupBox();
            this.rtbShippingAddress = new System.Windows.Forms.RichTextBox();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.lblShippingAddress = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpOrderItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.grpOrderInfo.SuspendLayout();
            this.grpDealerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPrint);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.grpOrderItem);
            this.panel1.Controls.Add(this.grpOrderInfo);
            this.panel1.Controls.Add(this.grpDealerInfo);
            this.panel1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(878, 652);
            this.panel1.TabIndex = 15;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnPrint.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPrint.Location = new System.Drawing.Point(619, 593);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Padding = new System.Windows.Forms.Padding(2);
            this.btnPrint.Size = new System.Drawing.Size(102, 43);
            this.btnPrint.TabIndex = 19;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Image = ((System.Drawing.Image)(resources.GetObject("btnBack.Image")));
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBack.Location = new System.Drawing.Point(753, 593);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(2);
            this.btnBack.Size = new System.Drawing.Size(102, 43);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // grpOrderItem
            // 
            this.grpOrderItem.Controls.Add(this.dgvOrderItem);
            this.grpOrderItem.Location = new System.Drawing.Point(5, 236);
            this.grpOrderItem.Margin = new System.Windows.Forms.Padding(5);
            this.grpOrderItem.Name = "grpOrderItem";
            this.grpOrderItem.Padding = new System.Windows.Forms.Padding(5);
            this.grpOrderItem.Size = new System.Drawing.Size(868, 347);
            this.grpOrderItem.TabIndex = 17;
            this.grpOrderItem.TabStop = false;
            this.grpOrderItem.Text = "Order Item";
            // 
            // dgvOrderItem
            // 
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItem.Location = new System.Drawing.Point(5, 25);
            this.dgvOrderItem.Margin = new System.Windows.Forms.Padding(5);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.ReadOnly = true;
            this.dgvOrderItem.RowHeadersWidth = 82;
            this.dgvOrderItem.RowTemplate.Height = 23;
            this.dgvOrderItem.Size = new System.Drawing.Size(858, 317);
            this.dgvOrderItem.TabIndex = 0;
            // 
            // grpOrderInfo
            // 
            this.grpOrderInfo.Controls.Add(this.txtOrderDate);
            this.grpOrderInfo.Controls.Add(this.txtOrderID);
            this.grpOrderInfo.Controls.Add(this.lblOrderDate);
            this.grpOrderInfo.Controls.Add(this.lblOrderID);
            this.grpOrderInfo.Location = new System.Drawing.Point(5, 5);
            this.grpOrderInfo.Margin = new System.Windows.Forms.Padding(5);
            this.grpOrderInfo.Name = "grpOrderInfo";
            this.grpOrderInfo.Padding = new System.Windows.Forms.Padding(5);
            this.grpOrderInfo.Size = new System.Drawing.Size(375, 221);
            this.grpOrderInfo.TabIndex = 15;
            this.grpOrderInfo.TabStop = false;
            this.grpOrderInfo.Text = "Order Information";
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.BackColor = System.Drawing.Color.White;
            this.txtOrderDate.Location = new System.Drawing.Point(142, 111);
            this.txtOrderDate.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.ReadOnly = true;
            this.txtOrderDate.Size = new System.Drawing.Size(201, 27);
            this.txtOrderDate.TabIndex = 4;
            // 
            // txtOrderID
            // 
            this.txtOrderID.BackColor = System.Drawing.Color.White;
            this.txtOrderID.Location = new System.Drawing.Point(142, 49);
            this.txtOrderID.Margin = new System.Windows.Forms.Padding(5);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.ReadOnly = true;
            this.txtOrderID.Size = new System.Drawing.Size(201, 27);
            this.txtOrderID.TabIndex = 3;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.Location = new System.Drawing.Point(7, 114);
            this.lblOrderDate.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(97, 19);
            this.lblOrderDate.TabIndex = 2;
            this.lblOrderDate.Text = "Order Date:";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(30, 52);
            this.lblOrderID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(76, 19);
            this.lblOrderID.TabIndex = 0;
            this.lblOrderID.Text = "Order ID:";
            // 
            // grpDealerInfo
            // 
            this.grpDealerInfo.Controls.Add(this.btnCancel);
            this.grpDealerInfo.Controls.Add(this.rtbShippingAddress);
            this.grpDealerInfo.Controls.Add(this.txtDealerName);
            this.grpDealerInfo.Controls.Add(this.lblShippingAddress);
            this.grpDealerInfo.Controls.Add(this.lblDealerName);
            this.grpDealerInfo.Location = new System.Drawing.Point(407, 5);
            this.grpDealerInfo.Margin = new System.Windows.Forms.Padding(5);
            this.grpDealerInfo.Name = "grpDealerInfo";
            this.grpDealerInfo.Padding = new System.Windows.Forms.Padding(5);
            this.grpDealerInfo.Size = new System.Drawing.Size(466, 221);
            this.grpDealerInfo.TabIndex = 16;
            this.grpDealerInfo.TabStop = false;
            this.grpDealerInfo.Text = "Dealer Information";
            // 
            // rtbShippingAddress
            // 
            this.rtbShippingAddress.BackColor = System.Drawing.Color.White;
            this.rtbShippingAddress.Location = new System.Drawing.Point(203, 114);
            this.rtbShippingAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rtbShippingAddress.Name = "rtbShippingAddress";
            this.rtbShippingAddress.ReadOnly = true;
            this.rtbShippingAddress.Size = new System.Drawing.Size(247, 93);
            this.rtbShippingAddress.TabIndex = 5;
            this.rtbShippingAddress.Text = "";
            // 
            // txtDealerName
            // 
            this.txtDealerName.BackColor = System.Drawing.Color.White;
            this.txtDealerName.Location = new System.Drawing.Point(203, 49);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(5);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(247, 27);
            this.txtDealerName.TabIndex = 4;
            // 
            // lblShippingAddress
            // 
            this.lblShippingAddress.AutoSize = true;
            this.lblShippingAddress.Location = new System.Drawing.Point(20, 114);
            this.lblShippingAddress.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblShippingAddress.Name = "lblShippingAddress";
            this.lblShippingAddress.Size = new System.Drawing.Size(147, 19);
            this.lblShippingAddress.TabIndex = 2;
            this.lblShippingAddress.Text = "Shipping Address:";
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Location = new System.Drawing.Point(50, 52);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(117, 19);
            this.lblDealerName.TabIndex = 0;
            this.lblDealerName.Text = "Dealer Name:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(444, -4);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(27, 26);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // FrmOrderDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(902, 675);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOrderDetail";
            this.Text = "FrmOrderDetail";
            this.Load += new System.EventHandler(this.FrmOrderDetail_Load);
            this.panel1.ResumeLayout(false);
            this.grpOrderItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.grpOrderInfo.ResumeLayout(false);
            this.grpOrderInfo.PerformLayout();
            this.grpDealerInfo.ResumeLayout(false);
            this.grpDealerInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox grpOrderItem;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.GroupBox grpOrderInfo;
        private System.Windows.Forms.TextBox txtOrderDate;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.GroupBox grpDealerInfo;
        private System.Windows.Forms.RichTextBox rtbShippingAddress;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label lblShippingAddress;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Button btnCancel;
    }
}