﻿
namespace ITP4915MProject
{
    partial class FrmEditOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEditOrder));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btnSelectItem = new System.Windows.Forms.Button();
            this.grpItem = new System.Windows.Forms.GroupBox();
            this.dgvOrderItem = new System.Windows.Forms.DataGridView();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.rtbRemark = new System.Windows.Forms.RichTextBox();
            this.cbxDealer = new System.Windows.Forms.ComboBox();
            this.lblDealer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_SaveToDraft = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.grpItem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).BeginInit();
            this.grpInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnConfirm);
            this.panel1.Controls.Add(this.btn_Remove);
            this.panel1.Controls.Add(this.btnSelectItem);
            this.panel1.Controls.Add(this.grpItem);
            this.panel1.Controls.Add(this.grpInformation);
            this.panel1.Controls.Add(this.btn_SaveToDraft);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(17, 17);
            this.panel1.Margin = new System.Windows.Forms.Padding(8);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1490, 1070);
            this.panel1.TabIndex = 1;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnConfirm.FlatAppearance.BorderSize = 2;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnConfirm.Location = new System.Drawing.Point(1001, 1001);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(410, 42);
            this.btnConfirm.TabIndex = 17;
            this.btnConfirm.Text = "Save";
            this.btnConfirm.UseVisualStyleBackColor = false;
            // 
            // btn_Remove
            // 
            this.btn_Remove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Remove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btn_Remove.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Remove.Image = ((System.Drawing.Image)(resources.GetObject("btn_Remove.Image")));
            this.btn_Remove.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Remove.Location = new System.Drawing.Point(194, 996);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Padding = new System.Windows.Forms.Padding(2);
            this.btn_Remove.Size = new System.Drawing.Size(121, 47);
            this.btn_Remove.TabIndex = 11;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Remove.UseVisualStyleBackColor = false;
            // 
            // btnSelectItem
            // 
            this.btnSelectItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSelectItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btnSelectItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectItem.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectItem.Image")));
            this.btnSelectItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectItem.Location = new System.Drawing.Point(33, 996);
            this.btnSelectItem.Name = "btnSelectItem";
            this.btnSelectItem.Padding = new System.Windows.Forms.Padding(2);
            this.btnSelectItem.Size = new System.Drawing.Size(121, 47);
            this.btnSelectItem.TabIndex = 10;
            this.btnSelectItem.Text = "Select Item";
            this.btnSelectItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectItem.UseVisualStyleBackColor = false;
            // 
            // grpItem
            // 
            this.grpItem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpItem.Controls.Add(this.dgvOrderItem);
            this.grpItem.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpItem.ForeColor = System.Drawing.Color.Black;
            this.grpItem.Location = new System.Drawing.Point(8, 145);
            this.grpItem.Name = "grpItem";
            this.grpItem.Size = new System.Drawing.Size(1438, 813);
            this.grpItem.TabIndex = 16;
            this.grpItem.TabStop = false;
            this.grpItem.Text = "Order Item";
            // 
            // dgvOrderItem
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvOrderItem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvOrderItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOrderItem.Location = new System.Drawing.Point(3, 43);
            this.dgvOrderItem.Name = "dgvOrderItem";
            this.dgvOrderItem.RowHeadersWidth = 82;
            this.dgvOrderItem.RowTemplate.Height = 37;
            this.dgvOrderItem.Size = new System.Drawing.Size(1432, 767);
            this.dgvOrderItem.TabIndex = 0;
            // 
            // grpInformation
            // 
            this.grpInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpInformation.Controls.Add(this.rtbRemark);
            this.grpInformation.Controls.Add(this.cbxDealer);
            this.grpInformation.Controls.Add(this.lblDealer);
            this.grpInformation.Controls.Add(this.label5);
            this.grpInformation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpInformation.Location = new System.Drawing.Point(8, 8);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(1474, 131);
            this.grpInformation.TabIndex = 15;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Basic Information";
            // 
            // rtbRemark
            // 
            this.rtbRemark.Location = new System.Drawing.Point(546, 38);
            this.rtbRemark.Name = "rtbRemark";
            this.rtbRemark.Size = new System.Drawing.Size(239, 87);
            this.rtbRemark.TabIndex = 10;
            this.rtbRemark.Text = "None";
            // 
            // cbxDealer
            // 
            this.cbxDealer.FormattingEnabled = true;
            this.cbxDealer.Location = new System.Drawing.Point(115, 33);
            this.cbxDealer.Name = "cbxDealer";
            this.cbxDealer.Size = new System.Drawing.Size(243, 46);
            this.cbxDealer.TabIndex = 9;
            // 
            // lblDealer
            // 
            this.lblDealer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDealer.AutoSize = true;
            this.lblDealer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.lblDealer.Location = new System.Drawing.Point(21, 36);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(127, 38);
            this.lblDealer.TabIndex = 6;
            this.lblDealer.Text = "Dealer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.label5.Location = new System.Drawing.Point(395, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 38);
            this.label5.TabIndex = 8;
            this.label5.Text = "Remark:";
            // 
            // btn_SaveToDraft
            // 
            this.btn_SaveToDraft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_SaveToDraft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.btn_SaveToDraft.FlatAppearance.BorderSize = 2;
            this.btn_SaveToDraft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveToDraft.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveToDraft.ForeColor = System.Drawing.Color.SandyBrown;
            this.btn_SaveToDraft.Location = new System.Drawing.Point(693, 996);
            this.btn_SaveToDraft.Name = "btn_SaveToDraft";
            this.btn_SaveToDraft.Size = new System.Drawing.Size(246, 42);
            this.btn_SaveToDraft.TabIndex = 13;
            this.btn_SaveToDraft.Text = "Back";
            this.btn_SaveToDraft.UseVisualStyleBackColor = false;
            // 
            // FrmEditOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 1104);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FrmEditOrder";
            this.Text = "FrmEditOrder";
            this.panel1.ResumeLayout(false);
            this.grpItem.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderItem)).EndInit();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btnSelectItem;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.DataGridView dgvOrderItem;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.RichTextBox rtbRemark;
        private System.Windows.Forms.ComboBox cbxDealer;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_SaveToDraft;
    }
}