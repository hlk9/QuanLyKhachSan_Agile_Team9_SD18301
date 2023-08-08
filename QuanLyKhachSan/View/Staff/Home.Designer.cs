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
            dtgListRoom.Location = new Point(14, 405);
            dtgListRoom.Margin = new Padding(3, 4, 3, 4);
            dtgListRoom.Name = "dtgListRoom";
            dtgListRoom.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dtgListRoom.RowTemplate.Height = 25;
            dtgListRoom.Size = new Size(1027, 396);
            dtgListRoom.TabIndex = 0;
            dtgListRoom.CellClick += dtgListRoom_CellClick;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(442, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(147, 41);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Welcome";
            // 
            // btnDatphong
            // 
            btnDatphong.BackColor = Color.MistyRose;
            btnDatphong.FlatStyle = FlatStyle.Flat;
            btnDatphong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDatphong.Location = new Point(22, 60);
            btnDatphong.Margin = new Padding(3, 4, 3, 4);
            btnDatphong.Name = "btnDatphong";
            btnDatphong.Size = new Size(86, 56);
            btnDatphong.TabIndex = 2;
            btnDatphong.Text = "Đặt phòng";
            btnDatphong.UseVisualStyleBackColor = false;
            btnDatphong.Click += btnDatphong_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 359);
            label1.Name = "label1";
            label1.Size = new Size(313, 41);
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
            groupBox1.Location = new Point(14, 75);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1027, 260);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thao tác";
            // 
            // button6
            // 
            button6.BackColor = Color.MistyRose;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(680, 60);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.Size = new Size(333, 56);
            button6.TabIndex = 8;
            button6.Text = "Các phòng đang được sử dụng";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // btnHuyPhong
            // 
            btnHuyPhong.BackColor = Color.MistyRose;
            btnHuyPhong.FlatStyle = FlatStyle.Flat;
            btnHuyPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnHuyPhong.Location = new Point(160, 60);
            btnHuyPhong.Margin = new Padding(3, 4, 3, 4);
            btnHuyPhong.Name = "btnHuyPhong";
            btnHuyPhong.Size = new Size(218, 56);
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
            button4.Location = new Point(160, 159);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(218, 56);
            button4.TabIndex = 6;
            button4.Text = "Dịch vụ yêu cầu";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGreen;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(935, 205);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(86, 47);
            button3.TabIndex = 5;
            button3.Text = "Tìm";
            button3.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(690, 215);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Tra cứu nhanh phòng";
            textBox1.Size = new Size(222, 27);
            textBox1.TabIndex = 4;
            // 
            // btnTraPhong
            // 
            btnTraPhong.BackColor = Color.MistyRose;
            btnTraPhong.FlatStyle = FlatStyle.Flat;
            btnTraPhong.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnTraPhong.Location = new Point(22, 159);
            btnTraPhong.Margin = new Padding(3, 4, 3, 4);
            btnTraPhong.Name = "btnTraPhong";
            btnTraPhong.Size = new Size(86, 56);
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
            button7.Location = new Point(963, 12);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(78, 35);
            button7.TabIndex = 9;
            button7.Text = "Thoát";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // lblCurrentName
            // 
            lblCurrentName.AutoSize = true;
            lblCurrentName.Location = new Point(883, 359);
            lblCurrentName.Name = "lblCurrentName";
            lblCurrentName.Size = new Size(0, 20);
            lblCurrentName.TabIndex = 10;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1055, 817);
            Controls.Add(lblCurrentName);
            Controls.Add(button7);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(dtgListRoom);
            Margin = new Padding(3, 4, 3, 4);
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