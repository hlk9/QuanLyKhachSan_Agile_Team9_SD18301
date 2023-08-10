namespace QuanLyKhachSan.View.Both
{
    partial class CurrentCustomer
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
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            SuspendLayout();
            // 
            // dtgData
            // 
            dtgData.AllowUserToAddRows = false;
            dtgData.AllowUserToDeleteRows = false;
            dtgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Location = new Point(12, 57);
            dtgData.Name = "dtgData";
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(776, 265);
            dtgData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(245, 9);
            label1.Name = "label1";
            label1.Size = new Size(279, 25);
            label1.TabIndex = 1;
            label1.Text = "Danh sách khách hàng hiện tại";
            // 
            // CurrentCustomer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 334);
            Controls.Add(label1);
            Controls.Add(dtgData);
            Name = "CurrentCustomer";
            Text = "CurrentCustomer";
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgData;
        private Label label1;
    }
}