namespace QuanLyKhachSan.View.Staff
{
    partial class FormCheckOutRoom
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
            dtgRoom = new DataGridView();
            label1 = new Label();
            lblName = new Label();
            lblRoom = new Label();
            lblTotalCost = new Label();
            txtFrom = new TextBox();
            label5 = new Label();
            label6 = new Label();
            txtTo = new TextBox();
            label2 = new Label();
            lblCurrentRoom = new Label();
            btnConfirm = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgRoom).BeginInit();
            SuspendLayout();
            // 
            // dtgRoom
            // 
            dtgRoom.AllowUserToAddRows = false;
            dtgRoom.AllowUserToDeleteRows = false;
            dtgRoom.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgRoom.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dtgRoom.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgRoom.Location = new Point(14, 316);
            dtgRoom.Margin = new Padding(3, 4, 3, 4);
            dtgRoom.Name = "dtgRoom";
            dtgRoom.ReadOnly = true;
            dtgRoom.RowHeadersWidth = 51;
            dtgRoom.RowTemplate.Height = 25;
            dtgRoom.ShowEditingIcon = false;
            dtgRoom.Size = new Size(887, 268);
            dtgRoom.TabIndex = 0;
            dtgRoom.CellClick += dtgRoom_CellClick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(890, 61);
            label1.TabIndex = 1;
            label1.Text = "Trả Phòng";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.Location = new Point(14, 122);
            lblName.Name = "lblName";
            lblName.Size = new Size(63, 23);
            lblName.TabIndex = 2;
            lblName.Text = "Họ Tên";
            lblName.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoom
            // 
            lblRoom.AutoSize = true;
            lblRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblRoom.Location = new Point(12, 211);
            lblRoom.Name = "lblRoom";
            lblRoom.Size = new Size(60, 23);
            lblRoom.TabIndex = 3;
            lblRoom.Text = "Phòng";
            lblRoom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalCost
            // 
            lblTotalCost.BorderStyle = BorderStyle.FixedSingle;
            lblTotalCost.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lblTotalCost.Location = new Point(714, 149);
            lblTotalCost.Name = "lblTotalCost";
            lblTotalCost.Size = new Size(186, 89);
            lblTotalCost.TabIndex = 4;
            lblTotalCost.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(370, 122);
            txtFrom.Margin = new Padding(3, 4, 3, 4);
            txtFrom.Name = "txtFrom";
            txtFrom.ReadOnly = true;
            txtFrom.Size = new Size(206, 27);
            txtFrom.TabIndex = 5;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(279, 122);
            label5.Name = "label5";
            label5.Size = new Size(85, 27);
            label5.TabIndex = 6;
            label5.Text = "Thời gian";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(279, 211);
            label6.Name = "label6";
            label6.Size = new Size(85, 27);
            label6.TabIndex = 7;
            label6.Text = "Tới";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtTo
            // 
            txtTo.Location = new Point(370, 211);
            txtTo.Margin = new Padding(3, 4, 3, 4);
            txtTo.Name = "txtTo";
            txtTo.ReadOnly = true;
            txtTo.Size = new Size(206, 27);
            txtTo.TabIndex = 8;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(714, 122);
            label2.Name = "label2";
            label2.Size = new Size(186, 27);
            label2.TabIndex = 9;
            label2.Text = "Tổng tiền";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCurrentRoom
            // 
            lblCurrentRoom.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblCurrentRoom.Location = new Point(14, 265);
            lblCurrentRoom.Name = "lblCurrentRoom";
            lblCurrentRoom.Size = new Size(350, 47);
            lblCurrentRoom.TabIndex = 10;
            lblCurrentRoom.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.LightGreen;
            btnConfirm.Location = new Point(714, 265);
            btnConfirm.Margin = new Padding(3, 4, 3, 4);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(186, 47);
            btnConfirm.TabIndex = 11;
            btnConfirm.Text = "Xác nhận đã thanh toán";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // FormCheckOutRoom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnConfirm);
            Controls.Add(lblCurrentRoom);
            Controls.Add(label2);
            Controls.Add(txtTo);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtFrom);
            Controls.Add(lblTotalCost);
            Controls.Add(lblRoom);
            Controls.Add(lblName);
            Controls.Add(label1);
            Controls.Add(dtgRoom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormCheckOutRoom";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCheckOutRoom";
            ((System.ComponentModel.ISupportInitialize)dtgRoom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgRoom;
        private Label label1;
        private Label lblName;
        private Label lblRoom;
        private Label lblTotalCost;
        private TextBox txtFrom;
        private Label label5;
        private Label label6;
        private TextBox txtTo;
        private Label label2;
        private Label lblCurrentRoom;
        private Button btnConfirm;
    }
}