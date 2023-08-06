namespace QuanLyKhachSan.View.Manager
{
    partial class RoomManagement
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbClass = new ComboBox();
            txtCost = new TextBox();
            txtName = new TextBox();
            txtID = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            lblCurrentID = new Label();
            btnClear = new Button();
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
            dtgData.Location = new Point(12, 256);
            dtgData.Name = "dtgData";
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(589, 182);
            dtgData.TabIndex = 0;
            dtgData.SelectionChanged += dtgData_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 50);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Room ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 98);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 2;
            label2.Text = "Room Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 140);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Room Class";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 180);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 4;
            label4.Text = "Room Cost";
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(107, 137);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(190, 23);
            cmbClass.TabIndex = 5;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(107, 180);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(190, 23);
            txtCost.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 90);
            txtName.Name = "txtName";
            txtName.Size = new Size(190, 23);
            txtName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(107, 47);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(190, 23);
            txtID.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(439, 40);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(162, 23);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(439, 98);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(162, 23);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(439, 69);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(162, 23);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblCurrentID
            // 
            lblCurrentID.AutoSize = true;
            lblCurrentID.Location = new Point(439, 190);
            lblCurrentID.Name = "lblCurrentID";
            lblCurrentID.Size = new Size(0, 15);
            lblCurrentID.TabIndex = 13;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(439, 127);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(162, 23);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear TextBox";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // RoomManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 450);
            Controls.Add(btnClear);
            Controls.Add(lblCurrentID);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtID);
            Controls.Add(txtName);
            Controls.Add(txtCost);
            Controls.Add(cmbClass);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtgData);
            Name = "RoomManagement";
            Text = "RoomManagement";
            ((System.ComponentModel.ISupportInitialize)dtgData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgData;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbClass;
        private TextBox txtCost;
        private TextBox txtName;
        private TextBox txtID;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Label lblCurrentID;
        private Button btnClear;
    }
}