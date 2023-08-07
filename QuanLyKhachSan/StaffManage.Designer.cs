namespace QuanLyKhachSan
{
    partial class StaffManage
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            groupBox1 = new GroupBox();
            txtPos = new TextBox();
            label7 = new Label();
            rtxtAddress = new RichTextBox();
            txtName = new TextBox();
            txtOld = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtID = new TextBox();
            label8 = new Label();
            dtgStaff = new DataGridView();
            btnSave = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnClose = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgStaff).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(837, 61);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Nhân Viên";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(6, 36);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 1;
            label2.Text = " Staff ID:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(6, 85);
            label3.Name = "label3";
            label3.Size = new Size(125, 25);
            label3.TabIndex = 2;
            label3.Text = "Staff Name:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(6, 133);
            label4.Name = "label4";
            label4.Size = new Size(125, 25);
            label4.TabIndex = 3;
            label4.Text = "Staff Old:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(6, 180);
            label5.Name = "label5";
            label5.Size = new Size(125, 25);
            label5.TabIndex = 4;
            label5.Text = "Staff Phone:";
            label5.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(433, 133);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 5;
            label6.Text = "Staff Address:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtPos);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(rtxtAddress);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtOld);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(837, 233);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // txtPos
            // 
            txtPos.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPos.Location = new Point(572, 82);
            txtPos.Name = "txtPos";
            txtPos.Size = new Size(230, 27);
            txtPos.TabIndex = 16;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(426, 85);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 15;
            label7.Text = "Staff Position:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // rtxtAddress
            // 
            rtxtAddress.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtAddress.Location = new Point(572, 130);
            rtxtAddress.Name = "rtxtAddress";
            rtxtAddress.Size = new Size(230, 75);
            rtxtAddress.TabIndex = 14;
            rtxtAddress.Text = "";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(152, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(230, 27);
            txtName.TabIndex = 13;
            // 
            // txtOld
            // 
            txtOld.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtOld.Location = new Point(152, 130);
            txtOld.Name = "txtOld";
            txtOld.Size = new Size(230, 27);
            txtOld.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(152, 177);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(230, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(572, 33);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(230, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtID
            // 
            txtID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtID.Location = new Point(152, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(230, 27);
            txtID.TabIndex = 8;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(426, 36);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 7;
            label8.Text = "Staff Email:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtgStaff
            // 
            dtgStaff.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgStaff.Location = new Point(12, 318);
            dtgStaff.Name = "dtgStaff";
            dtgStaff.RowHeadersWidth = 51;
            dtgStaff.RowTemplate.Height = 29;
            dtgStaff.Size = new Size(837, 188);
            dtgStaff.TabIndex = 8;
            dtgStaff.CellClick += dtgStaff_CellClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(445, 523);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 44);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(720, 523);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 44);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(584, 523);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(118, 44);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(49, 523);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(118, 44);
            btnClose.TabIndex = 12;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // StaffManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 579);
            Controls.Add(btnClose);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(dtgStaff);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "StaffManage";
            Text = "StaffManage";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgStaff).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private Label label8;
        private TextBox txtName;
        private TextBox txtOld;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtID;
        private RichTextBox rtxtAddress;
        private DataGridView dtgStaff;
        private Button btnSave;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnClose;
        private TextBox txtPos;
        private Label label7;
    }
}