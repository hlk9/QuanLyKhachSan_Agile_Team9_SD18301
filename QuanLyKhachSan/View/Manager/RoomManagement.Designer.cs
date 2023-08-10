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
            dtgData.Location = new Point(14, 341);
            dtgData.Margin = new Padding(3, 4, 3, 4);
            dtgData.Name = "dtgData";
            dtgData.RowHeadersWidth = 51;
            dtgData.RowTemplate.Height = 25;
            dtgData.Size = new Size(673, 243);
            dtgData.TabIndex = 0;
            dtgData.SelectionChanged += dtgData_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 67);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 1;
            label1.Text = "Room ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 131);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 2;
            label2.Text = "Room Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 187);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 3;
            label3.Text = "Room Class";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 240);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 4;
            label4.Text = "Room Cost";
            // 
            // cmbClass
            // 
            cmbClass.FormattingEnabled = true;
            cmbClass.Location = new Point(122, 183);
            cmbClass.Margin = new Padding(3, 4, 3, 4);
            cmbClass.Name = "cmbClass";
            cmbClass.Size = new Size(217, 28);
            cmbClass.TabIndex = 5;
            // 
            // txtCost
            // 
            txtCost.Location = new Point(122, 240);
            txtCost.Margin = new Padding(3, 4, 3, 4);
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(217, 27);
            txtCost.TabIndex = 6;
            // 
            // txtName
            // 
            txtName.Location = new Point(122, 120);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(217, 27);
            txtName.TabIndex = 7;
            // 
            // txtID
            // 
            txtID.Location = new Point(122, 63);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(217, 27);
            txtID.TabIndex = 8;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(502, 53);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(185, 31);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Thêm";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(502, 131);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(185, 31);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Xoá";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(502, 92);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(185, 31);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblCurrentID
            // 
            lblCurrentID.AutoSize = true;
            lblCurrentID.Location = new Point(502, 253);
            lblCurrentID.Name = "lblCurrentID";
            lblCurrentID.Size = new Size(0, 20);
            lblCurrentID.TabIndex = 13;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(502, 169);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(185, 31);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear TextBox";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // RoomManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 600);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "RoomManagement";
            StartPosition = FormStartPosition.CenterScreen;
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