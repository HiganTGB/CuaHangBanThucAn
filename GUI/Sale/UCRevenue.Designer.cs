namespace CuaHangBanThucAn.GUI.Sale
{
    partial class UCRevenue
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvRevenue = new DataGridView();
            txtBillSell = new TextBox();
            dPStart = new DateTimePicker();
            dPEnd = new DateTimePicker();
            btnStartEnd = new Button();
            txtTotalQuantity = new TextBox();
            txtTotal = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)lvRevenue).BeginInit();
            SuspendLayout();
            // 
            // lvRevenue
            // 
            lvRevenue.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvRevenue.Location = new Point(106, 136);
            lvRevenue.Name = "lvRevenue";
            lvRevenue.ReadOnly = true;
            lvRevenue.RowHeadersWidth = 51;
            lvRevenue.RowTemplate.Height = 29;
            lvRevenue.Size = new Size(782, 462);
            lvRevenue.TabIndex = 0;
            // 
            // txtBillSell
            // 
            txtBillSell.Location = new Point(763, 621);
            txtBillSell.Name = "txtBillSell";
            txtBillSell.ReadOnly = true;
            txtBillSell.Size = new Size(125, 27);
            txtBillSell.TabIndex = 1;
            // 
            // dPStart
            // 
            dPStart.Location = new Point(138, 77);
            dPStart.Name = "dPStart";
            dPStart.Size = new Size(250, 27);
            dPStart.TabIndex = 2;
            // 
            // dPEnd
            // 
            dPEnd.Location = new Point(482, 77);
            dPEnd.Name = "dPEnd";
            dPEnd.Size = new Size(250, 27);
            dPEnd.TabIndex = 3;
            // 
            // btnStartEnd
            // 
            btnStartEnd.Location = new Point(794, 78);
            btnStartEnd.Name = "btnStartEnd";
            btnStartEnd.Size = new Size(94, 29);
            btnStartEnd.TabIndex = 4;
            btnStartEnd.Text = "Thống kê";
            btnStartEnd.UseVisualStyleBackColor = true;
            btnStartEnd.Click += btnStartEnd_Click;
            // 
            // txtTotalQuantity
            // 
            txtTotalQuantity.Location = new Point(763, 667);
            txtTotalQuantity.Name = "txtTotalQuantity";
            txtTotalQuantity.ReadOnly = true;
            txtTotalQuantity.Size = new Size(125, 27);
            txtTotalQuantity.TabIndex = 5;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(763, 716);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 82);
            label1.Name = "label1";
            label1.Size = new Size(26, 20);
            label1.TabIndex = 7;
            label1.Text = "Từ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(410, 82);
            label2.Name = "label2";
            label2.Size = new Size(36, 20);
            label2.TabIndex = 8;
            label2.Text = "Đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(626, 628);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 9;
            label3.Text = "Tổng hoá đơn bán";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(643, 719);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 10;
            label4.Text = "Tổng doanh thu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(589, 667);
            label5.Name = "label5";
            label5.Size = new Size(168, 20);
            label5.TabIndex = 11;
            label5.Text = "Tổng số lượng thực đơn";
            // 
            // UCRevenue
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTotal);
            Controls.Add(txtTotalQuantity);
            Controls.Add(btnStartEnd);
            Controls.Add(dPEnd);
            Controls.Add(dPStart);
            Controls.Add(txtBillSell);
            Controls.Add(lvRevenue);
            Name = "UCRevenue";
            Size = new Size(1332, 853);
            ((System.ComponentModel.ISupportInitialize)lvRevenue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView lvRevenue;
        private TextBox txtBillSell;
        private DateTimePicker dPStart;
        private DateTimePicker dPEnd;
        private Button btnStartEnd;
        private TextBox txtTotalQuantity;
        private TextBox txtTotal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
