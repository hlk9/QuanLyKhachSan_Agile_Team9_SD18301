namespace QuanLyKhachSan
{
    partial class Service
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
            groupBox1 = new GroupBox();
            txtCost = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClose = new Button();
            dtgSer = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(676, 61);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Dịch Vụ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtCost);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 73);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 207);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(189, 152);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(284, 27);
            txtCost.TabIndex = 5;
            // 
            // txtName
            // 
            txtName.Location = new Point(189, 100);
            txtName.Name = "txtName";
            txtName.Size = new Size(284, 27);
            txtName.TabIndex = 4;
            // 
            // txtID
            // 
            txtID.Location = new Point(189, 50);
            txtID.Name = "txtID";
            txtID.Size = new Size(284, 27);
            txtID.TabIndex = 3;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(45, 150);
            label4.Name = "label4";
            label4.Size = new Size(123, 28);
            label4.TabIndex = 2;
            label4.Text = "Service Cost:";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(45, 98);
            label3.Name = "label3";
            label3.Size = new Size(123, 28);
            label3.TabIndex = 1;
            label3.Text = "Service Name:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(45, 48);
            label2.Name = "label2";
            label2.Size = new Size(123, 28);
            label2.TabIndex = 0;
            label2.Text = "Service ID:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(585, 89);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 38);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(585, 138);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 38);
            btnUpdate.TabIndex = 3;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(585, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 38);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(585, 236);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 38);
            btnClose.TabIndex = 5;
            btnClose.Text = "Cancel";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // dtgSer
            // 
            dtgSer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgSer.Location = new Point(12, 299);
            dtgSer.Name = "dtgSer";
            dtgSer.RowHeadersWidth = 51;
            dtgSer.RowTemplate.Height = 29;
            dtgSer.Size = new Size(676, 196);
            dtgSer.TabIndex = 6;
            dtgSer.CellClick += dtgSer_CellClick;
            // 
            // Service
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 507);
            Controls.Add(dtgSer);
            Controls.Add(btnClose);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Service";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Service";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgSer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtCost;
        private TextBox txtName;
        private TextBox txtID;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSave;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClose;
        private DataGridView dtgSer;
    }
}