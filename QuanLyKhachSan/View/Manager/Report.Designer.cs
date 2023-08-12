namespace QuanLyKhachSan.View.Manager
{
    partial class Report
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
            dateBegin = new DateTimePicker();
            dateEnd = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtRoomName = new TextBox();
            txtCusName = new TextBox();
            label5 = new Label();
            dtgData = new DataGridView();
            txtCost = new TextBox();
            label6 = new Label();
            txtPhone = new TextBox();
            label7 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgData).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(277, 12);
            label1.Name = "label1";
            label1.Size = new Size(244, 32);
            label1.TabIndex = 0;
            label1.Text = "Thống kê doanh thu";
            // 
            // dateBegin
            // 
            dateBegin.CustomFormat = "dd-MM-yyyy";
            dateBegin.Format = DateTimePickerFormat.Custom;
            dateBegin.Location = new Point(62, 91);
            dateBegin.Margin = new Padding(3, 4, 3, 4);
            dateBegin.Name = "dateBegin";
            dateBegin.Size = new Size(198, 27);
            dateBegin.TabIndex = 1;
            dateBegin.ValueChanged += dateBegin_ValueChanged;
            // 
            // dateEnd
            // 
            dateEnd.CustomFormat = "dd-MM-yyyy";
            dateEnd.Format = DateTimePickerFormat.Custom;
            dateEnd.Location = new Point(551, 88);
            dateEnd.Margin = new Padding(3, 4, 3, 4);
            dateEnd.Name = "dateEnd";
            dateEnd.Size = new Size(198, 27);
            dateEnd.TabIndex = 2;
            dateEnd.ValueChanged += dateBegin_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(489, 88);
            label2.Name = "label2";
            label2.Size = new Size(60, 32);
            label2.TabIndex = 3;
            label2.Text = "Đến";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 91);
            label3.Name = "label3";
            label3.Size = new Size(44, 32);
            label3.TabIndex = 4;
            label3.Text = "Từ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 159);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 5;
            label4.Text = "Tên Phòng";
            // 
            // txtRoomName
            // 
            txtRoomName.Location = new Point(93, 155);
            txtRoomName.Margin = new Padding(3, 4, 3, 4);
            txtRoomName.Name = "txtRoomName";
            txtRoomName.ReadOnly = true;
            txtRoomName.Size = new Size(167, 27);
            txtRoomName.TabIndex = 6;
            // 
            // txtCusName
            // 
            txtCusName.Location = new Point(582, 148);
            txtCusName.Margin = new Padding(3, 4, 3, 4);
            txtCusName.Name = "txtCusName";
            txtCusName.ReadOnly = true;
            txtCusName.Size = new Size(167, 27);
            txtCusName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(489, 152);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 7;
            label5.Text = "Khách hàng";
            // 
            // dtgData
            // 
            dtgData.AllowUserToAddRows = false;
            dtgData.AllowUserToDeleteRows = false;
            dtgData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dtgData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgData.Location = new Point(14, 399);
            dtgData.Margin = new Padding(3, 4, 3, 4);
            dtgData.Name = "dtgData";
            dtgData.ReadOnly = true;
            dtgData.RowHeadersWidth = 51;
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(736, 200);
            dtgData.TabIndex = 9;
            dtgData.SelectionChanged += dtgData_SelectionChanged;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(93, 220);
            txtCost.Margin = new Padding(3, 4, 3, 4);
            txtCost.Name = "txtCost";
            txtCost.ReadOnly = true;
            txtCost.Size = new Size(167, 27);
            txtCost.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 224);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 10;
            label6.Text = "Giá Phòng";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(582, 213);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.ReadOnly = true;
            txtPhone.Size = new Size(167, 27);
            txtPhone.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(489, 217);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 12;
            label7.Text = "Số ĐT";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTotal.Location = new Point(489, 293);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(0, 32);
            lblTotal.TabIndex = 14;
            // 
            // Report
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 615);
            Controls.Add(lblTotal);
            Controls.Add(txtPhone);
            Controls.Add(label7);
            Controls.Add(txtCost);
            Controls.Add(label6);
            Controls.Add(dtgData);
            Controls.Add(txtCusName);
            Controls.Add(label5);
            Controls.Add(txtRoomName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateEnd);
            Controls.Add(dateBegin);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Report";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report";
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateBegin;
        private DateTimePicker dateEnd;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtRoomName;
        private TextBox txtCusName;
        private Label label5;
        private DataGridView dtgData;
        private TextBox txtCost;
        private Label label6;
        private TextBox txtPhone;
        private Label label7;
        private Label lblTotal;
    }
}