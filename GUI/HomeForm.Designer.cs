namespace CuaHangBanThucAn.GUI
{
    partial class HomeForm
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
            panel_content = new Panel();
            ucRevenue1 = new Sale.UCRevenue();
            ucBill1 = new Sale.UCBill();
            ucSell1 = new Sale.UCSell();
            ucHome1 = new UCHome();
            ucTypeProduct1 = new Food.UCTypeProduct();
            ucFood1 = new Food.UCFood();
            ucAccount1 = new AccountManager.UCAccount();
            ucRole1 = new AccountManager.UCRole();
            panel2 = new Panel();
            btnLogout = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnHome = new Button();
            btnSell = new Button();
            btnFood = new Button();
            btnBill = new Button();
            btnType = new Button();
            btnRole = new Button();
            btnAccount = new Button();
            btnStatistic = new Button();
            btnMyAccount = new Button();
            lbName = new Label();
            lbRole = new Label();
            panel_menu = new Panel();
            label1 = new Label();
            panel_content.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel_menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel_content
            // 
            panel_content.BackColor = SystemColors.AppWorkspace;
            panel_content.Controls.Add(ucRevenue1);
            panel_content.Controls.Add(ucBill1);
            panel_content.Controls.Add(ucSell1);
            panel_content.Controls.Add(ucHome1);
            panel_content.Controls.Add(ucTypeProduct1);
            panel_content.Controls.Add(ucFood1);
            panel_content.Controls.Add(ucAccount1);
            panel_content.Controls.Add(ucRole1);
            panel_content.Dock = DockStyle.Top;
            panel_content.Location = new Point(250, 0);
            panel_content.Name = "panel_content";
            panel_content.Size = new Size(1332, 853);
            panel_content.TabIndex = 1;
            panel_content.Paint += panel_content_Paint;
            // 
            // ucRevenue1
            // 
            ucRevenue1.Dock = DockStyle.Fill;
            ucRevenue1.Location = new Point(0, 0);
            ucRevenue1.Name = "ucRevenue1";
            ucRevenue1.Size = new Size(1332, 853);
            ucRevenue1.TabIndex = 7;
            // 
            // ucBill1
            // 
            ucBill1.BackColor = SystemColors.AppWorkspace;
            ucBill1.Dock = DockStyle.Fill;
            ucBill1.Location = new Point(0, 0);
            ucBill1.Name = "ucBill1";
            ucBill1.Size = new Size(1332, 853);
            ucBill1.TabIndex = 6;
            // 
            // ucSell1
            // 
            ucSell1.BackColor = SystemColors.ActiveBorder;
            ucSell1.Dock = DockStyle.Fill;
            ucSell1.Location = new Point(0, 0);
            ucSell1.Name = "ucSell1";
            ucSell1.Size = new Size(1332, 853);
            ucSell1.TabIndex = 5;
            // 
            // ucHome1
            // 
            ucHome1.BackColor = SystemColors.ActiveBorder;
            ucHome1.Dock = DockStyle.Fill;
            ucHome1.Location = new Point(0, 0);
            ucHome1.Name = "ucHome1";
            ucHome1.Size = new Size(1332, 853);
            ucHome1.TabIndex = 4;
            // 
            // ucTypeProduct1
            // 
            ucTypeProduct1.Dock = DockStyle.Fill;
            ucTypeProduct1.Location = new Point(0, 0);
            ucTypeProduct1.Name = "ucTypeProduct1";
            ucTypeProduct1.Size = new Size(1332, 853);
            ucTypeProduct1.TabIndex = 3;
            ucTypeProduct1.Visible = false;
            // 
            // ucFood1
            // 
            ucFood1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ucFood1.Dock = DockStyle.Fill;
            ucFood1.Location = new Point(0, 0);
            ucFood1.Name = "ucFood1";
            ucFood1.Size = new Size(1332, 853);
            ucFood1.TabIndex = 2;
            ucFood1.Visible = false;
            // 
            // ucAccount1
            // 
            ucAccount1.Dock = DockStyle.Fill;
            ucAccount1.Location = new Point(0, 0);
            ucAccount1.Name = "ucAccount1";
            ucAccount1.Size = new Size(1332, 853);
            ucAccount1.TabIndex = 1;
            ucAccount1.Visible = false;
            // 
            // ucRole1
            // 
            ucRole1.Dock = DockStyle.Fill;
            ucRole1.Location = new Point(0, 0);
            ucRole1.Name = "ucRole1";
            ucRole1.Size = new Size(1332, 853);
            ucRole1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1331, 850);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(136, 773);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 29);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Đăng xuất";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnHome);
            flowLayoutPanel1.Controls.Add(btnSell);
            flowLayoutPanel1.Controls.Add(btnFood);
            flowLayoutPanel1.Controls.Add(btnBill);
            flowLayoutPanel1.Controls.Add(btnType);
            flowLayoutPanel1.Controls.Add(btnRole);
            flowLayoutPanel1.Controls.Add(btnAccount);
            flowLayoutPanel1.Controls.Add(btnStatistic);
            flowLayoutPanel1.Location = new Point(0, 190);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 565);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(3, 3);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(241, 29);
            btnHome.TabIndex = 0;
            btnHome.Text = "Trang Chủ";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // btnSell
            // 
            btnSell.Location = new Point(3, 38);
            btnSell.Name = "btnSell";
            btnSell.Size = new Size(241, 29);
            btnSell.TabIndex = 1;
            btnSell.Text = "Bán hàng";
            btnSell.UseVisualStyleBackColor = true;
            btnSell.Click += btnSell_Click;
            // 
            // btnFood
            // 
            btnFood.Location = new Point(3, 73);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(241, 29);
            btnFood.TabIndex = 2;
            btnFood.Text = "Quản lí thực đơn";
            btnFood.UseVisualStyleBackColor = true;
            btnFood.Click += btnFood_Click;
            // 
            // btnBill
            // 
            btnBill.Location = new Point(3, 108);
            btnBill.Name = "btnBill";
            btnBill.Size = new Size(241, 29);
            btnBill.TabIndex = 4;
            btnBill.Text = "Tra cứu hoá đơn";
            btnBill.UseVisualStyleBackColor = true;
            btnBill.Click += btnBill_Click;
            // 
            // btnType
            // 
            btnType.Location = new Point(3, 143);
            btnType.Name = "btnType";
            btnType.Size = new Size(241, 29);
            btnType.TabIndex = 3;
            btnType.Text = "Quản lí loại thực phẩm";
            btnType.UseVisualStyleBackColor = true;
            btnType.Click += btnType_Click;
            // 
            // btnRole
            // 
            btnRole.Location = new Point(3, 178);
            btnRole.Name = "btnRole";
            btnRole.Size = new Size(241, 29);
            btnRole.TabIndex = 5;
            btnRole.Text = "Quản lí chức vụ";
            btnRole.UseVisualStyleBackColor = true;
            btnRole.Click += btnRole_Click;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(3, 213);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(241, 29);
            btnAccount.TabIndex = 6;
            btnAccount.Text = "Quản lí tài khoản";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click;
            // 
            // btnStatistic
            // 
            btnStatistic.Location = new Point(3, 248);
            btnStatistic.Name = "btnStatistic";
            btnStatistic.Size = new Size(241, 29);
            btnStatistic.TabIndex = 7;
            btnStatistic.Text = "Thống kê";
            btnStatistic.UseVisualStyleBackColor = true;
            btnStatistic.Click += btnStatistic_Click;
            // 
            // btnMyAccount
            // 
            btnMyAccount.Location = new Point(78, 96);
            btnMyAccount.Name = "btnMyAccount";
            btnMyAccount.Size = new Size(133, 29);
            btnMyAccount.TabIndex = 5;
            btnMyAccount.Text = "Đổi mật khẩu";
            btnMyAccount.UseVisualStyleBackColor = true;
            btnMyAccount.Click += btnMyAccount_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(26, 28);
            lbName.Name = "lbName";
            lbName.Size = new Size(81, 20);
            lbName.TabIndex = 6;
            lbName.Text = "Chào ai đó";
            // 
            // lbRole
            // 
            lbRole.AutoSize = true;
            lbRole.Location = new Point(26, 61);
            lbRole.Name = "lbRole";
            lbRole.Size = new Size(61, 20);
            lbRole.TabIndex = 7;
            lbRole.Text = "Chức vụ";
            // 
            // panel_menu
            // 
            panel_menu.BackColor = SystemColors.ActiveCaption;
            panel_menu.Controls.Add(label1);
            panel_menu.Controls.Add(lbRole);
            panel_menu.Controls.Add(lbName);
            panel_menu.Controls.Add(btnMyAccount);
            panel_menu.Controls.Add(flowLayoutPanel1);
            panel_menu.Controls.Add(btnLogout);
            panel_menu.Controls.Add(panel2);
            panel_menu.Dock = DockStyle.Left;
            panel_menu.Location = new Point(0, 0);
            panel_menu.Name = "panel_menu";
            panel_menu.Size = new Size(250, 853);
            panel_menu.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 813);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 8;
            label1.Text = "Version 0.9 by Higan";
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1582, 853);
            Controls.Add(panel_content);
            Controls.Add(panel_menu);
            Name = "HomeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomeForm";
            FormClosing += HomeForm_FormClosing;
            FormClosed += HomeForm_FormClosed;
            panel_content.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel_menu.ResumeLayout(false);
            panel_menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel_content;
        private Panel panel2;
        private Button btnLogout;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnHome;
        private Button btnSell;
        private Button btnFood;
        private Button btnBill;
        private Button btnType;
        private Button btnRole;
        private Button btnAccount;
        private Button btnStatistic;
        private Button btnMyAccount;
        private Label lbName;
        private Label lbRole;
        private Panel panel_menu;
        private AccountManager.UCRole ucRole1;
        private AccountManager.UCAccount ucAccount1;
        private Food.UCTypeProduct ucTypeProduct1;
        private Food.UCFood ucFood1;
        private UCHome ucHome1;
        private Sale.UCSell ucSell1;
        private Sale.UCBill ucBill1;
        private Sale.UCRevenue ucRevenue1;
        private Label label1;
    }
}