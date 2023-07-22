namespace QuanLyKhachSan
{
    partial class Login
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
            lblTitle = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(57, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(417, 40);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Phần mềm quản lý khách sạn";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(175, 90);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(257, 23);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 93);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 2;
            label1.Text = "Tên người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 140);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(175, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(257, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(254, 193);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(75, 23);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(357, 193);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Thoát";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(552, 252);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(label1);
            Controls.Add(txtUserName);
            Controls.Add(lblTitle);
            Name = "Login";
            Text = "Login to System";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private TextBox txtUserName;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnCancel;
    }
}