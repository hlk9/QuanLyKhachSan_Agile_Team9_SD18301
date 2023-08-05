namespace QuanLyKhachSan
{
    partial class Booking
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
            groupBox1 = new GroupBox();
            dtpCheckOut = new DateTimePicker();
            dtpCheckIn = new DateTimePicker();
            txtRoomID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            groupBox2 = new GroupBox();
            rtxtNote = new RichTextBox();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtCMND = new TextBox();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dtgDatPhong = new DataGridView();
            btnClose = new Button();
            btnSave = new Button();
            lblHienThi = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatPhong).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(826, 61);
            label1.TabIndex = 1;
            label1.Text = "Đặt Phòng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(25, 55);
            label2.Name = "label2";
            label2.Size = new Size(125, 25);
            label2.TabIndex = 2;
            label2.Text = "Đặt Phỏng:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtpCheckOut);
            groupBox1.Controls.Add(dtpCheckIn);
            groupBox1.Controls.Add(txtRoomID);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(826, 129);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đặt phòng";
            // 
            // dtpCheckOut
            // 
            dtpCheckOut.CustomFormat = "yyyy-MM-dd";
            dtpCheckOut.Format = DateTimePickerFormat.Custom;
            dtpCheckOut.Location = new Point(567, 70);
            dtpCheckOut.Name = "dtpCheckOut";
            dtpCheckOut.Size = new Size(204, 30);
            dtpCheckOut.TabIndex = 15;
            // 
            // dtpCheckIn
            // 
            dtpCheckIn.CustomFormat = "yyyy-MM-dd";
            dtpCheckIn.Format = DateTimePickerFormat.Custom;
            dtpCheckIn.Location = new Point(567, 32);
            dtpCheckIn.Name = "dtpCheckIn";
            dtpCheckIn.Size = new Size(204, 30);
            dtpCheckIn.TabIndex = 14;
            // 
            // txtRoomID
            // 
            txtRoomID.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtRoomID.Location = new Point(156, 54);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.Size = new Size(204, 27);
            txtRoomID.TabIndex = 8;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(436, 74);
            label7.Name = "label7";
            label7.Size = new Size(125, 25);
            label7.TabIndex = 7;
            label7.Text = "Check Out:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(436, 35);
            label6.Name = "label6";
            label6.Size = new Size(125, 25);
            label6.TabIndex = 6;
            label6.Text = "Check In:";
            label6.TextAlign = ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rtxtNote);
            groupBox2.Controls.Add(txtName);
            groupBox2.Controls.Add(txtPhone);
            groupBox2.Controls.Add(txtEmail);
            groupBox2.Controls.Add(txtCMND);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            groupBox2.Location = new Point(12, 208);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(826, 174);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin khách hàng";
            // 
            // rtxtNote
            // 
            rtxtNote.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtNote.Location = new Point(567, 83);
            rtxtNote.Name = "rtxtNote";
            rtxtNote.Size = new Size(204, 73);
            rtxtNote.TabIndex = 13;
            rtxtNote.Text = "";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.Location = new Point(156, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(204, 27);
            txtName.TabIndex = 12;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhone.Location = new Point(156, 126);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(204, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(567, 37);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtCMND
            // 
            txtCMND.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtCMND.Location = new Point(156, 35);
            txtCMND.Name = "txtCMND";
            txtCMND.Size = new Size(204, 27);
            txtCMND.TabIndex = 9;
            // 
            // label12
            // 
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label12.Location = new Point(436, 83);
            label12.Name = "label12";
            label12.Size = new Size(125, 25);
            label12.TabIndex = 4;
            label12.Text = "Ghi Chú KH:";
            label12.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            label11.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label11.Location = new Point(436, 40);
            label11.Name = "label11";
            label11.Size = new Size(125, 25);
            label11.TabIndex = 3;
            label11.Text = "Email:";
            label11.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label10.Location = new Point(25, 129);
            label10.Name = "label10";
            label10.Size = new Size(125, 25);
            label10.TabIndex = 2;
            label10.Text = "Số ĐT: ";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label9.Location = new Point(25, 81);
            label9.Name = "label9";
            label9.Size = new Size(125, 25);
            label9.TabIndex = 1;
            label9.Text = "Họ Tên:";
            label9.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(25, 38);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 0;
            label8.Text = "CMND/Passport:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // dtgDatPhong
            // 
            dtgDatPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgDatPhong.Location = new Point(12, 478);
            dtgDatPhong.Name = "dtgDatPhong";
            dtgDatPhong.RowHeadersWidth = 51;
            dtgDatPhong.RowTemplate.Height = 29;
            dtgDatPhong.Size = new Size(826, 181);
            dtgDatPhong.TabIndex = 7;
            dtgDatPhong.CellClick += dtgDatPhong_CellClick;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Red;
            btnClose.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(561, 677);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(115, 46);
            btnClose.TabIndex = 8;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ActiveCaption;
            btnSave.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(694, 677);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 46);
            btnSave.TabIndex = 9;
            btnSave.Text = "Nhận Phòng";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lblHienThi
            // 
            lblHienThi.BorderStyle = BorderStyle.Fixed3D;
            lblHienThi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHienThi.ImageAlign = ContentAlignment.MiddleRight;
            lblHienThi.Location = new Point(12, 404);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(826, 51);
            lblHienThi.TabIndex = 10;
            lblHienThi.TextAlign = ContentAlignment.MiddleCenter;
            lblHienThi.Click += lblHienThi_Click;
            // 
            // Booking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 749);
            Controls.Add(lblHienThi);
            Controls.Add(btnSave);
            Controls.Add(btnClose);
            Controls.Add(dtgDatPhong);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Booking";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgDatPhong).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private TextBox txtRoomID;
        private Label label7;
        private Label label6;
        private GroupBox groupBox2;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private RichTextBox rtxtNote;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtCMND;
        private DataGridView dtgDatPhong;
        private Button btnClose;
        private Button btnSave;
        private DateTimePicker dtpCheckOut;
        private DateTimePicker dtpCheckIn;
        private Label lblHienThi;
    }
}