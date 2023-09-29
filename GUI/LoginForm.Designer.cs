namespace CuaHangBanThucAn.GUI
{
    partial class LoginForm
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            btnLogin = new Button();
            ckboxShow = new CheckBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            lbError = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(482, 853);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(479, 269);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(ckboxShow);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(lbError);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 278);
            panel2.Name = "panel2";
            panel2.Size = new Size(479, 575);
            panel2.TabIndex = 1;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(148, 245);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(200, 29);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // ckboxShow
            // 
            ckboxShow.AutoSize = true;
            ckboxShow.Location = new Point(366, 193);
            ckboxShow.Name = "ckboxShow";
            ckboxShow.Size = new Size(83, 24);
            ckboxShow.TabIndex = 5;
            ckboxShow.Text = "Hiển thị";
            ckboxShow.UseVisualStyleBackColor = true;
            ckboxShow.CheckedChanged += ckboxShow_CheckedChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(148, 191);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(200, 27);
            txtPassword.TabIndex = 4;
            txtPassword.KeyPress += txtPassword_KeyPress;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(149, 112);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(199, 27);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            txtEmail.KeyPress += txtEmail_KeyPress;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Location = new Point(162, 142);
            lbError.Name = "lbError";
            lbError.Size = new Size(137, 20);
            lbError.TabIndex = 2;
            lbError.Text = "Email không hợp lệ";
            lbError.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(84, 191);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(84, 112);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 853);
            Controls.Add(flowLayoutPanel1);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            KeyPress += LoginForm_KeyPress;
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private CheckBox ckboxShow;
        private TextBox txtPassword;
        private TextBox txtEmail;
        private Label lbError;
        private Label label2;
        private Label label1;
        private Button btnLogin;
    }
}