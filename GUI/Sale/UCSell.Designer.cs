namespace CuaHangBanThucAn.GUI.Sale
{
    partial class UCSell
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
            groupBox1 = new GroupBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            lvProduct = new DataGridView();
            txtSearch = new TextBox();
            groupBox2 = new GroupBox();
            txtDID = new TextBox();
            btnDel = new Button();
            lvBill = new DataGridView();
            txtName = new TextBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtTotalProductprice = new TextBox();
            btnAdd = new Button();
            txtQuantity = new NumericUpDown();
            txtPrice = new TextBox();
            txtID = new TextBox();
            groupBox4 = new GroupBox();
            btnSave = new Button();
            cbPrint = new CheckBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtChange = new TextBox();
            txtPay = new TextBox();
            txtTotalPrice = new TextBox();
            btnCancel = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lvProduct).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lvBill).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).BeginInit();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRefresh);
            groupBox1.Controls.Add(btnSearch);
            groupBox1.Controls.Add(lvProduct);
            groupBox1.Controls.Add(txtSearch);
            groupBox1.Location = new Point(16, 87);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 574);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Tìm kiếm Thực đơn";
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(429, 24);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(318, 24);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Tìm Kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lvProduct
            // 
            lvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvProduct.Location = new Point(6, 84);
            lvProduct.MultiSelect = false;
            lvProduct.Name = "lvProduct";
            lvProduct.ReadOnly = true;
            lvProduct.RowHeadersWidth = 51;
            lvProduct.RowTemplate.Height = 29;
            lvProduct.Size = new Size(554, 473);
            lvProduct.TabIndex = 1;
            lvProduct.CellContentClick += lvProduct_CellContentClick;
            lvProduct.RowEnter += lvProduct_RowEnter;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(49, 26);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(254, 27);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtDID);
            groupBox2.Controls.Add(btnDel);
            groupBox2.Controls.Add(lvBill);
            groupBox2.Location = new Point(588, 217);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(707, 444);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chi tiết hoá đơn";
            // 
            // txtDID
            // 
            txtDID.Location = new Point(532, 26);
            txtDID.Name = "txtDID";
            txtDID.ReadOnly = true;
            txtDID.Size = new Size(46, 27);
            txtDID.TabIndex = 5;
            txtDID.Visible = false;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(590, 26);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 1;
            btnDel.Text = "Xoá";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // lvBill
            // 
            lvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvBill.Location = new Point(29, 61);
            lvBill.MultiSelect = false;
            lvBill.Name = "lvBill";
            lvBill.ReadOnly = true;
            lvBill.RowHeadersWidth = 51;
            lvBill.RowTemplate.Height = 29;
            lvBill.Size = new Size(655, 322);
            lvBill.TabIndex = 0;
            lvBill.CellContentClick += lvBill_CellContentClick;
            lvBill.RowEnter += lvBill_RowEnter;
            // 
            // txtName
            // 
            txtName.Location = new Point(29, 87);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(215, 27);
            txtName.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtTotalProductprice);
            groupBox3.Controls.Add(btnAdd);
            groupBox3.Controls.Add(txtQuantity);
            groupBox3.Controls.Add(txtPrice);
            groupBox3.Controls.Add(txtID);
            groupBox3.Controls.Add(txtName);
            groupBox3.Location = new Point(588, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(707, 183);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin thực đơn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(270, 125);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 11;
            label4.Text = "Thành tiền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(270, 74);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(270, 29);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 9;
            label2.Text = "Giá bán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 51);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 8;
            label1.Text = "Tên Thực đơn";
            // 
            // txtTotalProductprice
            // 
            txtTotalProductprice.Location = new Point(375, 122);
            txtTotalProductprice.Name = "txtTotalProductprice";
            txtTotalProductprice.ReadOnly = true;
            txtTotalProductprice.RightToLeft = RightToLeft.Yes;
            txtTotalProductprice.Size = new Size(168, 27);
            txtTotalProductprice.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(562, 72);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 75);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Ghi";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(474, 74);
            txtQuantity.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(69, 27);
            txtQuantity.TabIndex = 5;
            txtQuantity.ValueChanged += txtQuantity_ValueChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(375, 26);
            txtPrice.Name = "txtPrice";
            txtPrice.ReadOnly = true;
            txtPrice.RightToLeft = RightToLeft.Yes;
            txtPrice.Size = new Size(168, 27);
            txtPrice.TabIndex = 4;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtID
            // 
            txtID.Location = new Point(58, 137);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(50, 27);
            txtID.TabIndex = 3;
            txtID.Visible = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnSave);
            groupBox4.Controls.Add(cbPrint);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(txtChange);
            groupBox4.Controls.Add(txtPay);
            groupBox4.Controls.Add(txtTotalPrice);
            groupBox4.Location = new Point(634, 675);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(661, 164);
            groupBox4.TabIndex = 4;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin thanh toán";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(565, 77);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 66);
            btnSave.TabIndex = 9;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // cbPrint
            // 
            cbPrint.AutoSize = true;
            cbPrint.Checked = true;
            cbPrint.CheckState = CheckState.Checked;
            cbPrint.Location = new Point(535, 32);
            cbPrint.Name = "cbPrint";
            cbPrint.Size = new Size(120, 24);
            cbPrint.TabIndex = 8;
            cbPrint.Text = "Xuất hoá đơn";
            cbPrint.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(31, 124);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 7;
            label7.Text = "Tiền thối";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(31, 80);
            label6.Name = "label6";
            label6.Size = new Size(127, 20);
            label6.TabIndex = 6;
            label6.Text = "Số tiền khách đưa";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 33);
            label5.Name = "label5";
            label5.Size = new Size(157, 20);
            label5.TabIndex = 5;
            label5.Text = "Số tiền cần thanh toán";
            // 
            // txtChange
            // 
            txtChange.Location = new Point(209, 121);
            txtChange.Name = "txtChange";
            txtChange.ReadOnly = true;
            txtChange.Size = new Size(218, 27);
            txtChange.TabIndex = 4;
            // 
            // txtPay
            // 
            txtPay.Location = new Point(209, 77);
            txtPay.Name = "txtPay";
            txtPay.Size = new Size(218, 27);
            txtPay.TabIndex = 3;
            txtPay.TextChanged += txtPay_TextChanged;
            // 
            // txtTotalPrice
            // 
            txtTotalPrice.Location = new Point(209, 26);
            txtTotalPrice.Name = "txtTotalPrice";
            txtTotalPrice.ReadOnly = true;
            txtTotalPrice.Size = new Size(218, 27);
            txtTotalPrice.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(488, 685);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 66);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Huỷ hoá đơn";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // UCSell
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            Controls.Add(btnCancel);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "UCSell";
            Size = new Size(1332, 853);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lvProduct).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lvBill).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtQuantity).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView lvProduct;
        private TextBox txtSearch;
        private GroupBox groupBox2;
        private DataGridView lvBill;
        private Button btnDel;
        private TextBox txtName;
        private GroupBox groupBox3;
        private Button btnAdd;
        private NumericUpDown txtQuantity;
        private TextBox txtPrice;
        private TextBox txtID;
        private Label label1;
        private TextBox txtTotalProductprice;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox4;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox txtChange;
        private TextBox txtPay;
        private TextBox txtTotalPrice;
        private Button btnSave;
        private CheckBox cbPrint;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtDID;
        private Button btnCancel;
    }
}
