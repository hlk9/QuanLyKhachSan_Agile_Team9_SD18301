namespace QuanLyKhachSan.View.Manager
{
    partial class HomeManager
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
            dtgData = new DataGridView();
            btnStaffManager = new Button();
            btnServices = new Button();
            btnReport = new Button();
            btnRoomManager = new Button();
            label1 = new Label();
            btnHistory = new Button();
            button1 = new Button();
            groupBox1 = new GroupBox();
            label8 = new Label();
            txtCusName = new TextBox();
            label9 = new Label();
            txtPhone = new TextBox();
            label5 = new Label();
            txtCost = new TextBox();
            label4 = new Label();
            txtRoomClass = new TextBox();
            label3 = new Label();
            txtRoomID = new TextBox();
            label2 = new Label();
            txtRoomName = new TextBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dtgData
            // 
            dtgData.AllowUserToAddRows = false;
            dtgData.AllowUserToDeleteRows = false;
            dtgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Location = new Point(14, 447);
            dtgData.Margin = new Padding(3, 4, 3, 4);
            dtgData.Name = "dtgData";
            dtgData.ReadOnly = true;
            dtgData.RowHeadersWidth = 51;
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(1098, 320);
            dtgData.TabIndex = 0;
            dtgData.SelectionChanged += dtgData_SelectionChanged;
            // 
            // btnStaffManager
            // 
            btnStaffManager.Location = new Point(7, 167);
            btnStaffManager.Margin = new Padding(3, 4, 3, 4);
            btnStaffManager.Name = "btnStaffManager";
            btnStaffManager.Size = new Size(151, 57);
            btnStaffManager.TabIndex = 1;
            btnStaffManager.Text = "Quản lý nhân viên";
            btnStaffManager.UseVisualStyleBackColor = true;
            btnStaffManager.Click += btnStaffManager_Click;
            // 
            // btnServices
            // 
            btnServices.Location = new Point(203, 167);
            btnServices.Margin = new Padding(3, 4, 3, 4);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(151, 57);
            btnServices.TabIndex = 2;
            btnServices.Text = "Quản lý Dịch Vụ";
            btnServices.UseVisualStyleBackColor = true;
            btnServices.Click += btnServices_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(203, 267);
            btnReport.Margin = new Padding(3, 4, 3, 4);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(151, 57);
            btnReport.TabIndex = 3;
            btnReport.Text = "Thống kê";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnRoomManager
            // 
            btnRoomManager.Location = new Point(7, 64);
            btnRoomManager.Margin = new Padding(3, 4, 3, 4);
            btnRoomManager.Name = "btnRoomManager";
            btnRoomManager.Size = new Size(151, 57);
            btnRoomManager.TabIndex = 4;
            btnRoomManager.Text = "Quản lý Phòng";
            btnRoomManager.UseVisualStyleBackColor = true;
            btnRoomManager.Click += btnRoomManager_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 388);
            label1.Name = "label1";
            label1.Size = new Size(497, 37);
            label1.TabIndex = 5;
            label1.Text = "Danh sách các phòng đang hoạt động";
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(7, 267);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(151, 57);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "Lịch sử đặt phòng";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // button1
            // 
            button1.Location = new Point(203, 64);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(151, 57);
            button1.TabIndex = 7;
            button1.Text = "Danh sách khách hàng đang thuê";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtCusName);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtCost);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtRoomClass);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtRoomID);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtRoomName);
            groupBox1.Location = new Point(14, 16);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(730, 368);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phòng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(405, 119);
            label8.Name = "label8";
            label8.Size = new Size(116, 20);
            label8.TabIndex = 11;
            label8.Text = "Customer Name";
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(519, 115);
            txtCusName.Margin = new Padding(3, 4, 3, 4);
            txtCusName.Name = "txtCusName";
            txtCusName.ReadOnly = true;
            txtCusName.Size = new Size(204, 27);
            txtCusName.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(405, 171);
            label9.Name = "label9";
            label9.Size = new Size(108, 20);
            label9.TabIndex = 9;
            label9.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(519, 167);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(204, 27);
            txtPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 221);
            label5.Name = "label5";
            label5.Size = new Size(38, 20);
            label5.TabIndex = 7;
            label5.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(106, 217);
            txtCost.Margin = new Padding(3, 4, 3, 4);
            txtCost.Name = "txtCost";
            txtCost.ReadOnly = true;
            txtCost.Size = new Size(204, 27);
            txtCost.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 171);
            label4.Name = "label4";
            label4.Size = new Size(42, 20);
            label4.TabIndex = 5;
            label4.Text = "Class";
            // 
            // txtRoomClass
            // 
            txtRoomClass.Location = new Point(106, 167);
            txtRoomClass.Margin = new Padding(3, 4, 3, 4);
            txtRoomClass.Name = "txtRoomClass";
            txtRoomClass.ReadOnly = true;
            txtRoomClass.Size = new Size(204, 27);
            txtRoomClass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 68);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 3;
            label3.Text = "Room ID";
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(106, 64);
            txtRoomID.Margin = new Padding(3, 4, 3, 4);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.ReadOnly = true;
            txtRoomID.Size = new Size(204, 27);
            txtRoomID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 120);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 1;
            label2.Text = "Room Name";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(106, 116);
            txtRoomName.Margin = new Padding(3, 4, 3, 4);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.ReadOnly = true;
            txtRoomName.Size = new Size(204, 27);
            txtRoomName.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnServices);
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnStaffManager);
            groupBox2.Controls.Add(btnHistory);
            groupBox2.Controls.Add(btnReport);
            groupBox2.Controls.Add(btnRoomManager);
            groupBox2.Location = new Point(751, 16);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(361, 368);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hành động";
            // 
            // HomeManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1126, 783);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dtgData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "HomeManager";
            Text = "HomeManager";
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgData;
        private Button btnStaffManager;
        private Button btnServices;
        private Button btnReport;
        private Button btnRoomManager;
        private Label label1;
        private Button btnHistory;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private TextBox txtRoomName;
        private Label label3;
        private TextBox txtRoomID;
        private Label label8;
        private TextBox txtCusName;
        private Label label9;
        private TextBox txtPhone;
        private Label label5;
        private TextBox txtCost;
        private Label label4;
        private TextBox txtRoomClass;
    }
}