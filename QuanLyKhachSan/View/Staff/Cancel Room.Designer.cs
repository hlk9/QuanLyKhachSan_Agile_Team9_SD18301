namespace QuanLyKhachSan.View.Staff
{
    partial class Cancel_Room
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
            btnCancel = new Button();
            btnClose = new Button();
            lblHienThi = new Label();
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
            dtgData.Location = new Point(14, 231);
            dtgData.Margin = new Padding(3, 4, 3, 4);
            dtgData.Name = "dtgData";
            dtgData.ReadOnly = true;
            dtgData.RowHeadersWidth = 51;
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(968, 352);
            dtgData.TabIndex = 0;
            dtgData.SelectionChanged += dtgData_SelectionChanged;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Coral;
            btnCancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.White;
            btnCancel.Location = new Point(850, 16);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(131, 56);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Xác nhận HUỶ";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.SeaShell;
            btnClose.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(14, 16);
            btnClose.Margin = new Padding(3, 4, 3, 4);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(131, 56);
            btnClose.TabIndex = 2;
            btnClose.Text = "Thoát";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // lblHienThi
            // 
            lblHienThi.BorderStyle = BorderStyle.Fixed3D;
            lblHienThi.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblHienThi.ImageAlign = ContentAlignment.MiddleRight;
            lblHienThi.Location = new Point(14, 141);
            lblHienThi.Name = "lblHienThi";
            lblHienThi.Size = new Size(968, 72);
            lblHienThi.TabIndex = 11;
            lblHienThi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Cancel_Room
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 599);
            Controls.Add(lblHienThi);
            Controls.Add(btnClose);
            Controls.Add(btnCancel);
            Controls.Add(dtgData);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Cancel_Room";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cancel_Room";
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgData;
        private Button btnCancel;
        private Button btnClose;
        private Label lblHienThi;
    }
}