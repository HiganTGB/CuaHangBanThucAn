namespace CuaHangBanThucAn.GUI.AccountManager
{
    partial class UCAccount
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
            btnSearch = new Button();
            txtPass = new TextBox();
            txtEmail = new TextBox();
            txtRole = new TextBox();
            label5 = new Label();
            label4 = new Label();
            lable3 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            cbType = new ComboBox();
            txtName = new TextBox();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            label2 = new Label();
            lvAccount = new DataGridView();
            tabPage1 = new TabPage();
            lbError = new Label();
            ckbShow = new CheckBox();
            groupDetail = new GroupBox();
            lbDError = new Label();
            txtDRole = new TextBox();
            txtDEmail = new TextBox();
            label11 = new Label();
            lable10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            btnDel = new Button();
            btnEdit = new Button();
            cbDType = new ComboBox();
            txtDName = new TextBox();
            txtDID = new TextBox();
            tabPage2 = new TabPage();
            tabMenu = new TabControl();
            ((System.ComponentModel.ISupportInitialize)lvAccount).BeginInit();
            tabPage1.SuspendLayout();
            groupDetail.SuspendLayout();
            tabPage2.SuspendLayout();
            tabMenu.SuspendLayout();
            SuspendLayout();
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
            // txtPass
            // 
            txtPass.Location = new Point(627, 61);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(262, 27);
            txtPass.TabIndex = 15;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(627, 21);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 27);
            txtEmail.TabIndex = 14;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(93, 116);
            txtRole.Name = "txtRole";
            txtRole.ReadOnly = true;
            txtRole.Size = new Size(125, 27);
            txtRole.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 68);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Mật khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(549, 28);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 9;
            label4.Text = "Email";
            // 
            // lable3
            // 
            lable3.AutoSize = true;
            lable3.Location = new Point(9, 123);
            lable3.Name = "lable3";
            lable3.Size = new Size(51, 20);
            lable3.TabIndex = 8;
            lable3.Text = "Quyền";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 21);
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
            cbType.SelectedIndexChanged += cbType_SelectedIndexChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(93, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(345, 27);
            txtName.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(31, 25);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(374, 27);
            txtSearch.TabIndex = 2;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 68);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 7;
            label2.Text = "Chức vụ";
            // 
            // lvAccount
            // 
            lvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvAccount.Location = new Point(19, 299);
            lvAccount.MultiSelect = false;
            lvAccount.Name = "lvAccount";
            lvAccount.RowHeadersWidth = 51;
            lvAccount.RowTemplate.Height = 29;
            lvAccount.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lvAccount.Size = new Size(778, 539);
            lvAccount.TabIndex = 3;
            lvAccount.CellContentClick += lvAccount_CellContentClick;
            lvAccount.RowEnter += lvAccount_RowEnter;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lbError);
            tabPage1.Controls.Add(ckbShow);
            tabPage1.Controls.Add(txtPass);
            tabPage1.Controls.Add(txtEmail);
            tabPage1.Controls.Add(txtRole);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(lable3);
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
            tabPage1.Text = "Thêm tài khoản";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Location = new Point(921, 23);
            lbError.Name = "lbError";
            lbError.Size = new Size(137, 20);
            lbError.TabIndex = 17;
            lbError.Text = "Email không hợp lệ";
            lbError.Visible = false;
            // 
            // ckbShow
            // 
            ckbShow.AutoSize = true;
            ckbShow.Location = new Point(923, 62);
            ckbShow.Name = "ckbShow";
            ckbShow.Size = new Size(83, 24);
            ckbShow.TabIndex = 16;
            ckbShow.Text = "Hiển thị";
            ckbShow.UseVisualStyleBackColor = true;
            ckbShow.CheckedChanged += ckbShow_CheckedChanged;
            // 
            // groupDetail
            // 
            groupDetail.Controls.Add(lbDError);
            groupDetail.Controls.Add(txtDRole);
            groupDetail.Controls.Add(txtDEmail);
            groupDetail.Controls.Add(label11);
            groupDetail.Controls.Add(lable10);
            groupDetail.Controls.Add(label9);
            groupDetail.Controls.Add(label8);
            groupDetail.Controls.Add(label7);
            groupDetail.Controls.Add(btnDel);
            groupDetail.Controls.Add(btnEdit);
            groupDetail.Controls.Add(cbDType);
            groupDetail.Controls.Add(txtDName);
            groupDetail.Controls.Add(txtDID);
            groupDetail.Location = new Point(844, 299);
            groupDetail.Name = "groupDetail";
            groupDetail.Size = new Size(470, 539);
            groupDetail.TabIndex = 4;
            groupDetail.TabStop = false;
            groupDetail.Text = "Chi tiết tài khoản";
            // 
            // lbDError
            // 
            lbDError.AutoSize = true;
            lbDError.Location = new Point(119, 285);
            lbDError.Name = "lbDError";
            lbDError.Size = new Size(137, 20);
            lbDError.TabIndex = 20;
            lbDError.Text = "Email không hợp lệ";
            lbDError.Visible = false;
            // 
            // txtDRole
            // 
            txtDRole.Location = new Point(122, 207);
            txtDRole.Name = "txtDRole";
            txtDRole.Size = new Size(148, 27);
            txtDRole.TabIndex = 19;
            // 
            // txtDEmail
            // 
            txtDEmail.Location = new Point(122, 255);
            txtDEmail.Name = "txtDEmail";
            txtDEmail.Size = new Size(307, 27);
            txtDEmail.TabIndex = 17;
            txtDEmail.TextChanged += txtDEmail_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 262);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 13;
            label11.Text = "Email";
            // 
            // lable10
            // 
            lable10.AutoSize = true;
            lable10.Location = new Point(36, 207);
            lable10.Name = "lable10";
            lable10.Size = new Size(51, 20);
            lable10.TabIndex = 12;
            lable10.Text = "Quyền";
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
            cbDType.SelectedIndexChanged += cbDType_SelectedIndexChanged;
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
            // tabMenu
            // 
            tabMenu.Controls.Add(tabPage1);
            tabMenu.Controls.Add(tabPage2);
            tabMenu.Location = new Point(19, 14);
            tabMenu.Name = "tabMenu";
            tabMenu.SelectedIndex = 0;
            tabMenu.Size = new Size(1295, 192);
            tabMenu.TabIndex = 5;
            // 
            // UCAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lvAccount);
            Controls.Add(groupDetail);
            Controls.Add(tabMenu);
            Name = "UCAccount";
            Size = new Size(1332, 853);
            ((System.ComponentModel.ISupportInitialize)lvAccount).EndInit();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupDetail.ResumeLayout(false);
            groupDetail.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSearch;
        private TextBox txtPass;
        private TextBox txtEmail;
        private TextBox txtRole;
        private Label label5;
        private Label label4;
        private Label lable3;
        private Label label1;
        private Button btnAdd;
        private ComboBox cbType;
        private TextBox txtName;
        private TextBox txtSearch;
        private Button btnRefresh;
        private Label label2;
        private DataGridView lvAccount;
        private TabPage tabPage1;
        private CheckBox ckbShow;
        private GroupBox groupDetail;
        private TextBox txtDRole;
        private TextBox txtDEmail;
        private Label label11;
        private Label lable10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnDel;
        private Button btnEdit;
        private ComboBox cbDType;
        private TextBox txtDName;
        private TextBox txtDID;
        private TabPage tabPage2;
        private TabControl tabMenu;
        private Label lbError;
        private Label lbDError;
    }
}
