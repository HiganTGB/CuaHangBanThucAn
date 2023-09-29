namespace CuaHangBanThucAn.GUI.Food
{
    partial class UCFood
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
            groupDetail = new GroupBox();
            txtDStock = new TextBox();
            txtDDiscount = new TextBox();
            txtDPrice = new TextBox();
            label13 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnDel = new Button();
            btnEdit = new Button();
            cbDType = new ComboBox();
            txtDLastPrice = new TextBox();
            txtDName = new TextBox();
            txtDID = new TextBox();
            tabMenu = new TabControl();
            tabPage1 = new TabPage();
            txtDiscount = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            label6 = new Label();
            txtLastPrice = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            cbType = new ComboBox();
            txtName = new TextBox();
            tabPage2 = new TabPage();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            btnSearch = new Button();
            lvProduct = new DataGridView();
            groupDetail.SuspendLayout();
            tabMenu.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lvProduct).BeginInit();
            SuspendLayout();
            // 
            // groupDetail
            // 
            groupDetail.Controls.Add(txtDStock);
            groupDetail.Controls.Add(txtDDiscount);
            groupDetail.Controls.Add(txtDPrice);
            groupDetail.Controls.Add(label13);
            groupDetail.Controls.Add(label12);
            groupDetail.Controls.Add(label11);
            groupDetail.Controls.Add(label10);
            groupDetail.Controls.Add(label9);
            groupDetail.Controls.Add(label8);
            groupDetail.Controls.Add(label7);
            groupDetail.Controls.Add(btnDel);
            groupDetail.Controls.Add(btnEdit);
            groupDetail.Controls.Add(cbDType);
            groupDetail.Controls.Add(txtDLastPrice);
            groupDetail.Controls.Add(txtDName);
            groupDetail.Controls.Add(txtDID);
            groupDetail.Location = new Point(840, 300);
            groupDetail.Name = "groupDetail";
            groupDetail.Size = new Size(470, 539);
            groupDetail.TabIndex = 1;
            groupDetail.TabStop = false;
            groupDetail.Text = "Chi tiết thực đơn";
            // 
            // txtDStock
            // 
            txtDStock.Location = new Point(122, 207);
            txtDStock.Name = "txtDStock";
            txtDStock.Size = new Size(148, 27);
            txtDStock.TabIndex = 19;
            // 
            // txtDDiscount
            // 
            txtDDiscount.Location = new Point(122, 305);
            txtDDiscount.Name = "txtDDiscount";
            txtDDiscount.Size = new Size(122, 27);
            txtDDiscount.TabIndex = 18;
            txtDDiscount.TextChanged += txtDPrice_TextChanged;
            // 
            // txtDPrice
            // 
            txtDPrice.Location = new Point(122, 255);
            txtDPrice.Name = "txtDPrice";
            txtDPrice.Size = new Size(122, 27);
            txtDPrice.TabIndex = 17;
            txtDPrice.TextChanged += txtDPrice_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(44, 357);
            label13.Name = "label13";
            label13.Size = new Size(60, 20);
            label13.TabIndex = 16;
            label13.Text = "Giá bán";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(36, 308);
            label12.Name = "label12";
            label12.Size = new Size(69, 20);
            label12.TabIndex = 15;
            label12.Text = "Giảm giá";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 262);
            label11.Name = "label11";
            label11.Size = new Size(60, 20);
            label11.TabIndex = 13;
            label11.Text = "Giá gốc";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(36, 207);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 12;
            label10.Text = "Số lượng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 159);
            label9.Name = "label9";
            label9.Size = new Size(37, 20);
            label9.TabIndex = 11;
            label9.Text = "Loại";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 107);
            label8.Name = "label8";
            label8.Size = new Size(32, 20);
            label8.TabIndex = 10;
            label8.Text = "Tên";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 46);
            label7.Name = "label7";
            label7.Size = new Size(24, 20);
            label7.TabIndex = 9;
            label7.Text = "ID";
            // 
            // btnDel
            // 
            btnDel.Location = new Point(287, 454);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 8;
            btnDel.Text = "Xoá";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(122, 454);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbDType
            // 
            cbDType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDType.FormattingEnabled = true;
            cbDType.Location = new Point(119, 156);
            cbDType.Name = "cbDType";
            cbDType.Size = new Size(151, 28);
            cbDType.TabIndex = 6;
            // 
            // txtDLastPrice
            // 
            txtDLastPrice.Location = new Point(119, 354);
            txtDLastPrice.Name = "txtDLastPrice";
            txtDLastPrice.ReadOnly = true;
            txtDLastPrice.Size = new Size(125, 27);
            txtDLastPrice.TabIndex = 5;
            // 
            // txtDName
            // 
            txtDName.Location = new Point(119, 104);
            txtDName.Name = "txtDName";
            txtDName.Size = new Size(310, 27);
            txtDName.TabIndex = 1;
            // 
            // txtDID
            // 
            txtDID.Location = new Point(119, 39);
            txtDID.Name = "txtDID";
            txtDID.ReadOnly = true;
            txtDID.Size = new Size(97, 27);
            txtDID.TabIndex = 0;
            // 
            // tabMenu
            // 
            tabMenu.Controls.Add(tabPage1);
            tabMenu.Controls.Add(tabPage2);
            tabMenu.Location = new Point(15, 15);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(1295, 192);
            tabMenu.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtDiscount);
            tabPage1.Controls.Add(txtPrice);
            tabPage1.Controls.Add(txtStock);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtLastPrice);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(cbType);
            tabPage1.Controls.Add(txtName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1287, 159);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thêm thực đơn";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtDiscount
            // 
            txtDiscount.Location = new Point(372, 116);
            txtDiscount.Name = "txtDiscount";
            txtDiscount.Size = new Size(125, 27);
            txtDiscount.TabIndex = 15;
            txtDiscount.TextChanged += txtPrice_TextChanged;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(372, 66);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 14;
            txtPrice.TextChanged += txtPrice_TextChanged;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(93, 116);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(125, 27);
            txtStock.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(539, 66);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 12;
            label6.Text = "Giá bán";
            // 
            // txtLastPrice
            // 
            txtLastPrice.Location = new Point(615, 63);
            txtLastPrice.Name = "txtLastPrice";
            txtLastPrice.ReadOnly = true;
            txtLastPrice.Size = new Size(125, 27);
            txtLastPrice.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(277, 119);
            label5.Name = "label5";
            label5.Size = new Size(95, 20);
            label5.TabIndex = 10;
            label5.Text = "Giảm giá (%)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 65);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 9;
            label4.Text = "Giá gốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 120);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 8;
            label3.Text = "Số lượng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 65);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 7;
            label2.Text = "Loại";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 18);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 6;
            label1.Text = "Tên";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(627, 116);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(93, 62);
            cbType.Name = "cbType";
            cbType.Size = new Size(151, 28);
            cbType.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(93, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 27);
            txtName.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtSearch);
            tabPage2.Controls.Add(btnRefresh);
            tabPage2.Controls.Add(btnSearch);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1287, 159);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Tìm kiếm";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(31, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(374, 27);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(447, 75);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(94, 29);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Làm mới";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(447, 23);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 0;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lvProduct
            // 
            lvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvProduct.Location = new Point(15, 300);
            lvProduct.MultiSelect = false;
            lvProduct.Name = "lvProduct";
            lvProduct.RowHeadersWidth = 51;
            lvProduct.RowTemplate.Height = 29;
            lvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lvProduct.Size = new Size(778, 539);
            lvProduct.TabIndex = 0;
            lvProduct.CellContentClick += lvProduct_CellContentClick;
            lvProduct.RowEnter += lvProduct_RowEnter;
            // 
            // UCFood
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Controls.Add(tabMenu);
            Controls.Add(groupDetail);
            Controls.Add(lvProduct);
            Name = "UCFood";
            Size = new Size(1332, 853);
            groupDetail.ResumeLayout(false);
            groupDetail.PerformLayout();
            tabMenu.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lvProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupDetail;
        private TextBox txtDName;
        private TextBox txtDID;
        private Button btnDel;
        private Button btnEdit;
        private ComboBox cbDType;
        private TextBox txtDLastPrice;
        private TabControl tabMenu;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private DataGridView lvProduct;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private ComboBox cbType;
        private TextBox txtName;
        private Label label6;
        private TextBox txtLastPrice;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Button btnSearch;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label12;
        private Label label13;
        private TextBox txtDiscount;
        private TextBox txtPrice;
        private TextBox txtStock;
        private TextBox txtDStock;
        private TextBox txtDDiscount;
        private TextBox txtDPrice;
    }
}
