namespace QuanLyKhachSan.View.Both
{
    partial class Booking_History
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
            dtgData = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(329, 12);
            label1.Name = "label1";
            label1.Size = new Size(245, 37);
            label1.TabIndex = 0;
            label1.Text = "Lịch sử đặt phòng";
            // 
            // dtgData
            // 
            dtgData.AllowUserToAddRows = false;
            dtgData.AllowUserToDeleteRows = false;
            dtgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Location = new Point(14, 56);
            dtgData.Margin = new Padding(3, 4, 3, 4);
            dtgData.Name = "dtgData";
            dtgData.RowHeadersWidth = 51;
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(887, 528);
            dtgData.TabIndex = 1;
            // 
            // Booking_History
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(dtgData);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Booking_History";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Booking_History";
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgData;
    }
}