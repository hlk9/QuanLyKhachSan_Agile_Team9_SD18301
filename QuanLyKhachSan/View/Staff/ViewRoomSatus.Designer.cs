namespace QuanLyKhachSan
{
    partial class ViewRoomSatus
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
            dtgViewstatus = new DataGridView();
            lblShow = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgViewstatus).BeginInit();
            SuspendLayout();
            // 
            // dtgViewstatus
            // 
            dtgViewstatus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgViewstatus.Location = new Point(12, 78);
            dtgViewstatus.Name = "dtgViewstatus";
            dtgViewstatus.RowHeadersWidth = 51;
            dtgViewstatus.RowTemplate.Height = 29;
            dtgViewstatus.Size = new Size(561, 248);
            dtgViewstatus.TabIndex = 0;
            dtgViewstatus.CellClick += dtgViewstatus_CellClick;
            // 
            // lblShow
            // 
            lblShow.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblShow.Location = new Point(12, 9);
            lblShow.Name = "lblShow";
            lblShow.Size = new Size(559, 51);
            lblShow.TabIndex = 1;
            lblShow.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ViewRoomSatus
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(583, 338);
            Controls.Add(lblShow);
            Controls.Add(dtgViewstatus);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "ViewRoomSatus";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewRoomSatus";
            ((System.ComponentModel.ISupportInitialize)dtgViewstatus).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgViewstatus;
        private Label lblShow;
    }
}