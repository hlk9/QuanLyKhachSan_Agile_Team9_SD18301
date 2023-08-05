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
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            SuspendLayout();
            // 
            // dtgData
            // 
            dtgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Location = new Point(12, 335);
            dtgData.Name = "dtgData";
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(961, 240);
            dtgData.TabIndex = 0;
            // 
            // btnStaffManager
            // 
            btnStaffManager.Location = new Point(12, 174);
            btnStaffManager.Name = "btnStaffManager";
            btnStaffManager.Size = new Size(132, 43);
            btnStaffManager.TabIndex = 1;
            btnStaffManager.Text = "Quản lý nhân viên";
            btnStaffManager.UseVisualStyleBackColor = true;
            // 
            // btnServices
            // 
            btnServices.Location = new Point(12, 55);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(132, 43);
            btnServices.TabIndex = 2;
            btnServices.Text = "Quản lý Dịch Vụ";
            btnServices.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(12, 114);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(132, 43);
            btnReport.TabIndex = 3;
            btnReport.Text = "Thống kê";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnRoomManager
            // 
            btnRoomManager.Location = new Point(166, 114);
            btnRoomManager.Name = "btnRoomManager";
            btnRoomManager.Size = new Size(132, 43);
            btnRoomManager.TabIndex = 4;
            btnRoomManager.Text = "Quản lý Phòng";
            btnRoomManager.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 291);
            label1.Name = "label1";
            label1.Size = new Size(353, 30);
            label1.TabIndex = 5;
            label1.Text = "Danh sách các phòng và trạng thái";
            // 
            // btnHistory
            // 
            btnHistory.Location = new Point(166, 174);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(132, 43);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "Lịch sử đặt phòng";
            btnHistory.UseVisualStyleBackColor = true;
            // 
            // HomeManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(985, 587);
            Controls.Add(btnHistory);
            Controls.Add(label1);
            Controls.Add(btnRoomManager);
            Controls.Add(btnReport);
            Controls.Add(btnServices);
            Controls.Add(btnStaffManager);
            Controls.Add(dtgData);
            Name = "HomeManager";
            Text = "HomeManager";
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
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
    }
}