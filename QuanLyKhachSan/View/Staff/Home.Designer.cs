namespace QuanLyKhachSan.View.Staff
{
    partial class Home
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
            dtgListRoom = new DataGridView();
            lblTitle = new Label();
            btnDatphong = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button6 = new Button();
            btnHuyPhong = new Button();
            button4 = new Button();
            button3 = new Button();
            textBox1 = new TextBox();
            btnTraPhong = new Button();
            button7 = new Button();
            lblCurrentName = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgListRoom
            // 
            dtgListRoom.AllowUserToAddRows = false;
            dtgListRoom.AllowUserToDeleteRows = false;
            dtgListRoom.AllowUserToResizeColumns = false;
            dtgListRoom.AllowUserToResizeRows = false;
            dtgListRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgListRoom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            dtgListRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgListRoom.Location = new Point(12, 304);
            dtgListRoom.Name = "dtgListRoom";
            dtgListRoom.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgListRoom.RowTemplate.Height = 25;
            dtgListRoom.Size = new Size(899, 297);
            dtgListRoom.TabIndex = 0;
            dtgListRoom.CellClick += dtgListRoom_CellClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(387, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(119, 32);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Welcome";
            // 
            // btnDatphong
            // 
            btnDatphong.BackColor = Color.MistyRose;
            btnDatphong.FlatStyle = FlatStyle.Flat;
            btnDatphong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatphong.Location = new Point(19, 45);
            btnDatphong.Name = "btnDatphong";
            btnDatphong.Size = new Size(75, 42);
            btnDatphong.TabIndex = 2;
            btnDatphong.Text = "Đặt phòng";
            btnDatphong.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 269);
            label1.Name = "label1";
            label1.Size = new Size(256, 32);
            label1.TabIndex = 3;
            label1.Text = "Danh sách các phòng";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(btnHuyPhong);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(btnTraPhong);
            groupBox1.Controls.Add(btnDatphong);
            groupBox1.Location = new Point(12, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(899, 195);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác";
            // 
            // button6
            // 
            button6.BackColor = Color.MistyRose;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(595, 45);
            button6.Name = "button6";
            button6.Size = new Size(291, 42);
            button6.TabIndex = 8;
            button6.Text = "Các phòng đang được sử dụng";
            button6.UseVisualStyleBackColor = false;
            // 
            // btnHuyPhong
            // 
            btnHuyPhong.BackColor = Color.MistyRose;
            btnHuyPhong.FlatStyle = FlatStyle.Flat;
            btnHuyPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyPhong.Location = new Point(140, 45);
            btnHuyPhong.Name = "btnHuyPhong";
            btnHuyPhong.Size = new Size(191, 42);
            btnHuyPhong.TabIndex = 7;
            btnHuyPhong.Text = "Huỷ phòng";
            btnHuyPhong.UseVisualStyleBackColor = false;
            btnHuyPhong.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MistyRose;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(140, 119);
            button4.Name = "button4";
            button4.Size = new Size(191, 42);
            button4.TabIndex = 6;
            button4.Text = "Dịch vụ yêu cầu";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(818, 154);
            button3.Name = "button3";
            button3.Size = new Size(75, 35);
            button3.TabIndex = 5;
            button3.Text = "Tìm";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(604, 161);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tra cứu nhanh phòng";
            textBox1.Size = new Size(195, 23);
            textBox1.TabIndex = 4;
            // 
            // btnTraPhong
            // 
            btnTraPhong.BackColor = Color.MistyRose;
            btnTraPhong.FlatStyle = FlatStyle.Flat;
            btnTraPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTraPhong.Location = new Point(19, 119);
            btnTraPhong.Name = "btnTraPhong";
            btnTraPhong.Size = new Size(75, 42);
            btnTraPhong.TabIndex = 3;
            btnTraPhong.Text = "Trả Phòng";
            btnTraPhong.UseVisualStyleBackColor = false;
            btnTraPhong.Click += button2_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Sienna;
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(843, 9);
            button7.Name = "button7";
            button7.Size = new Size(68, 26);
            button7.TabIndex = 9;
            button7.Text = "Thoát";
            button7.UseVisualStyleBackColor = false;
            // 
            // lblCurrentName
            // 
            lblCurrentName.AutoSize = true;
            lblCurrentName.Location = new Point(773, 269);
            lblCurrentName.Name = "lblCurrentName";
            lblCurrentName.Size = new Size(38, 15);
            lblCurrentName.TabIndex = 10;
            lblCurrentName.Text = "label2";
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(923, 613);
            Controls.Add(lblCurrentName);
            Controls.Add(button7);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(dtgListRoom);
            Name = "Home";
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)dtgListRoom).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgListRoom;
        private Label lblTitle;
        private Button button1;
        private Label label1;
        private GroupBox groupBox1;
        private Button button2;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private TextBox textBox1;
        private Button button7;
        private Label lblCurrentName;
        private Button btnDatphong;
        private Button btnHuyPhong;
        private Button btnTraPhong;
    }
}