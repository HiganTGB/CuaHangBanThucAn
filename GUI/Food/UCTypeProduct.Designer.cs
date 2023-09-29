namespace CuaHangBanThucAn.GUI.Food
{
    partial class UCTypeProduct
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
            label1 = new Label();
            btnAdd = new Button();
            txtName = new TextBox();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            lvType = new DataGridView();
            tabPage1 = new TabPage();
            groupDetail = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            btnDel = new Button();
            btnEdit = new Button();
            txtDName = new TextBox();
            txtDID = new TextBox();
            tabPage2 = new TabPage();
            tabMenu = new TabControl();
            ((System.ComponentModel.ISupportInitialize)lvType).BeginInit();
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
            btnAdd.Location = new Point(467, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
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
            // lvType
            // 
            lvType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            lvType.Location = new Point(19, 299);
            lvType.MultiSelect = false;
            lvType.Name = "lvType";
            lvType.RowHeadersWidth = 51;
            lvType.RowTemplate.Height = 29;
            lvType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            lvType.Size = new Size(778, 539);
            lvType.TabIndex = 3;
            lvType.CellContentClick += lvType_CellContentClick;
            lvType.RowEnter += lvType_RowEnter;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(btnAdd);
            tabPage1.Controls.Add(txtName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1287, 159);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thêm loại";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupDetail
            // 
            groupDetail.Controls.Add(label8);
            groupDetail.Controls.Add(label7);
            groupDetail.Controls.Add(btnDel);
            groupDetail.Controls.Add(btnEdit);
            groupDetail.Controls.Add(txtDName);
            groupDetail.Controls.Add(txtDID);
            groupDetail.Location = new Point(844, 299);
            groupDetail.Name = "groupDetail";
            groupDetail.Size = new Size(470, 539);
            groupDetail.TabIndex = 4;
            groupDetail.TabStop = false;
            groupDetail.Text = "Chi tiết loại";
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
            btnEdit.Location = new Point(119, 454);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(94, 29);
            btnEdit.TabIndex = 7;
            btnEdit.Text = "Sửa";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
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
            // UCTypeProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lvType);
            Controls.Add(groupDetail);
            Controls.Add(tabMenu);
            Name = "UCTypeProduct";
            Size = new Size(1332, 853);
            ((System.ComponentModel.ISupportInitialize)lvType).EndInit();
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
        private Label label1;
        private Button btnAdd;
        private TextBox txtName;
        private TextBox txtSearch;
        private Button btnRefresh;
        private DataGridView lvType;
        private TabPage tabPage1;
        private GroupBox groupDetail;
        private Label label8;
        private Label label7;
        private Button btnDel;
        private Button btnEdit;
        private TextBox txtDName;
        private TextBox txtDID;
        private TabPage tabPage2;
        private TabControl tabMenu;
    }
}
