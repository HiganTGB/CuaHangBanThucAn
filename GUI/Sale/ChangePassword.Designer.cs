namespace CuaHangBanThucAn.GUI.Sale
{
    partial class ChangePassword
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
            txtID = new TextBox();
            txtName = new TextBox();
            txtRole = new TextBox();
            txtConfirm = new TextBox();
            txtPass = new TextBox();
            txtNewPass = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnChange = new Button();
            cbShow = new CheckBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // txtID
            // 
            txtID.Location = new Point(75, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(51, 27);
            txtID.TabIndex = 0;
            // 
            // txtName
            // 
            txtName.Location = new Point(75, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(178, 27);
            txtName.TabIndex = 1;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(75, 112);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(178, 27);
            txtRole.TabIndex = 2;
            // 
            // txtConfirm
            // 
            txtConfirm.Location = new Point(166, 321);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.Size = new Size(165, 27);
            txtConfirm.TabIndex = 3;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(166, 223);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(165, 27);
            txtPass.TabIndex = 4;
            // 
            // txtNewPass
            // 
            txtNewPass.Location = new Point(166, 276);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(165, 27);
            txtNewPass.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 33);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 6;
            label1.Text = "ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtRole);
            groupBox1.Enabled = false;
            groupBox1.Location = new Point(29, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(383, 178);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin tài khoản";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 151);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 10;
            label7.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(75, 145);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(262, 27);
            txtEmail.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 112);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 8;
            label3.Text = "Chức vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 71);
            label2.Name = "label2";
            label2.Size = new Size(32, 20);
            label2.TabIndex = 7;
            label2.Text = "Tên";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 223);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 8;
            label4.Text = "Mật khẩu cũ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 279);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 9;
            label5.Text = "Mật khẩu mới";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 328);
            label6.Name = "label6";
            label6.Size = new Size(134, 20);
            label6.TabIndex = 10;
            label6.Text = "Xác nhận mật khẩu";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(175, 376);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(156, 29);
            btnChange.TabIndex = 11;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += btnChange_Click;
            // 
            // cbShow
            // 
            cbShow.AutoSize = true;
            cbShow.Location = new Point(345, 279);
            cbShow.Name = "cbShow";
            cbShow.Size = new Size(83, 24);
            cbShow.TabIndex = 12;
            cbShow.Text = "Hiển thị";
            cbShow.UseVisualStyleBackColor = true;
            cbShow.CheckedChanged += cbShow_CheckedChanged;
            // 
            // ChangePassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(cbShow);
            Controls.Add(btnChange);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(txtNewPass);
            Controls.Add(txtPass);
            Controls.Add(txtConfirm);
            Name = "ChangePassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangePassword";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtRole;
        private TextBox txtConfirm;
        private TextBox txtPass;
        private TextBox txtNewPass;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnChange;
        private CheckBox cbShow;
        private Label label7;
        private TextBox txtEmail;
    }
}