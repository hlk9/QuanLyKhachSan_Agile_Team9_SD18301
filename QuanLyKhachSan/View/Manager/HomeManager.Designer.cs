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
            dtgData.Location = new Point(12, 335);
            dtgData.Name = "dtgData";
            dtgData.ReadOnly = true;
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(961, 240);
            dtgData.TabIndex = 0;
            dtgData.SelectionChanged += dtgData_SelectionChanged;
            // 
            // btnStaffManager
            // 
            btnStaffManager.Location = new Point(6, 125);
            btnStaffManager.Name = "btnStaffManager";
            btnStaffManager.Size = new Size(132, 43);
            btnStaffManager.TabIndex = 1;
            btnStaffManager.Text = "Quản lý nhân viên";
            btnStaffManager.UseVisualStyleBackColor = true;
            // 
            // btnServices
            // 
            btnServices.Location = new Point(178, 125);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(132, 43);
            btnServices.TabIndex = 2;
            btnServices.Text = "Quản lý Dịch Vụ";
            btnServices.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(178, 200);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(132, 43);
            btnReport.TabIndex = 3;
            btnReport.Text = "Thống kê";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnRoomManager
            // 
            btnRoomManager.Location = new Point(6, 48);
            btnRoomManager.Name = "btnRoomManager";
            btnRoomManager.Size = new Size(132, 43);
            btnRoomManager.TabIndex = 4;
            btnRoomManager.Text = "Quản lý Phòng";
            btnRoomManager.UseVisualStyleBackColor = true;
            btnRoomManager.Click += btnRoomManager_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 291);
            label1.Name = "label1";
            label1.Size = new Size(387, 30);
            label1.TabIndex = 5;
            label1.Text = "Danh sách các phòng đang hoạt động";
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(6, 200);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(132, 43);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "Lịch sử đặt phòng";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(178, 48);
            button1.Name = "button1";
            button1.Size = new Size(132, 43);
            button1.TabIndex = 7;
            button1.Text = "Danh sách khách hàng đang thue";
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(639, 276);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Phòng";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(354, 89);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 11;
            label8.Text = "Customer Name";
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(454, 86);
            txtCusName.Name = "txtCusName";
            txtCusName.ReadOnly = true;
            txtCusName.Size = new Size(179, 23);
            txtCusName.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(354, 128);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 9;
            label9.Text = "Phone Number";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(454, 125);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(179, 23);
            txtPhone.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 166);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 7;
            label5.Text = "Cost";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(93, 163);
            txtCost.Name = "txtCost";
            txtCost.ReadOnly = true;
            txtCost.Size = new Size(179, 23);
            txtCost.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 128);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "Class";
            // 
            // txtRoomClass
            // 
            txtRoomClass.Location = new Point(93, 125);
            txtRoomClass.Name = "txtRoomClass";
            txtRoomClass.ReadOnly = true;
            txtRoomClass.Size = new Size(179, 23);
            txtRoomClass.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 51);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 3;
            label3.Text = "Room ID";
            // 
            // txtRoomID
            // 
            txtRoomID.Location = new Point(93, 48);
            txtRoomID.Name = "txtRoomID";
            txtRoomID.ReadOnly = true;
            txtRoomID.Size = new Size(179, 23);
            txtRoomID.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 90);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 1;
            label2.Text = "Room Name";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(93, 87);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.ReadOnly = true;
            txtRoomName.Size = new Size(179, 23);
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
            groupBox2.Location = new Point(657, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 276);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Hành động";
            // 
            // HomeManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 587);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(dtgData);
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