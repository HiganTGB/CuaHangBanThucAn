namespace CuaHangBanThucAn.GUI.Sale
{
    partial class UCBill
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
            lvList = new DataGridView();
            lvDetail = new DataGridView();
            groupBox1 = new GroupBox();
            txtDate = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            txtChange = new TextBox();
            txtPay = new TextBox();
            txtTotal = new TextBox();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)lvList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lvDetail).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lvList
            // 
            lvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvList.Location = new Point(25, 124);
            lvList.Name = "lvList";
            lvList.ReadOnly = true;
            lvList.RowHeadersWidth = 51;
            lvList.RowTemplate.Height = 29;
            lvList.Size = new Size(431, 478);
            lvList.TabIndex = 0;
            lvList.CellContentClick += lvList_CellContentClick;
            lvList.RowEnter += lvList_RowEnter;
            // 
            // lvDetail
            // 
            lvDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvDetail.Location = new Point(22, 139);
            lvDetail.Name = "lvDetail";
            lvDetail.ReadOnly = true;
            lvDetail.RowHeadersWidth = 51;
            lvDetail.RowTemplate.Height = 29;
            lvDetail.Size = new Size(525, 387);
            lvDetail.TabIndex = 1;
            lvDetail.CellContentClick += dataGridView2_CellContentClick;
            lvDetail.RowEnter += lvDetail_RowEnter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtChange);
            groupBox1.Controls.Add(txtPay);
            groupBox1.Controls.Add(txtTotal);
            groupBox1.Controls.Add(lvDetail);
            groupBox1.Location = new Point(704, 48);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(569, 754);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chi tiết hoá đơn";
            // 
            // txtDate
            // 
            txtDate.Location = new Point(132, 93);
            txtDate.Name = "txtDate";
            txtDate.ReadOnly = true;
            txtDate.Size = new Size(415, 27);
            txtDate.TabIndex = 7;
            // 
            // txtName
            // 
            txtName.Location = new Point(289, 34);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(163, 27);
            txtName.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(112, 36);
            txtID.Name = "txtID";
            txtID.Size = new Size(38, 27);
            txtID.TabIndex = 5;
            // 
            // txtChange
            // 
            txtChange.Location = new Point(422, 651);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(125, 27);
            txtChange.TabIndex = 4;
            // 
            // txtPay
            // 
            txtPay.Location = new Point(422, 598);
            txtPay.Name = "txtPay";
            txtPay.ReadOnly = true;
            txtPay.Size = new Size(125, 27);
            txtPay.TabIndex = 3;
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(422, 549);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(125, 27);
            txtTotal.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(25, 78);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(233, 27);
            txtSearch.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRefresh);
            groupBox2.Controls.Add(btnSearch);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(lvList);
            groupBox2.Location = new Point(83, 63);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(475, 663);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm kiếm hoá đơn";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(375, 76);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(279, 76);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 39);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã hoá đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 37);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 9;
            label2.Text = "Nhân viên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 95);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Ngày lập";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 552);
            label4.Name = "label4";
            label4.Size = new Size(102, 20);
            label4.TabIndex = 11;
            label4.Text = "Tổng hoá đơn";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 601);
            label5.Name = "label5";
            label5.Size = new Size(119, 20);
            label5.TabIndex = 12;
            label5.Text = "Số tiền khách trả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(308, 654);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 13;
            label6.Text = "Tiền thối lại";
            // 
            // UCBill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UCBill";
            Size = new Size(1332, 853);
            ((System.ComponentModel.ISupportInitialize)lvList).EndInit();
            ((System.ComponentModel.ISupportInitialize)lvDetail).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView lvList;
        private DataGridView lvDetail;
        private GroupBox groupBox1;
        private TextBox txtDate;
        private TextBox txtName;
        private TextBox txtID;
        private TextBox txtChange;
        private TextBox txtPay;
        private TextBox txtTotal;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private Button btnRefresh;
        private Button btnSearch;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
