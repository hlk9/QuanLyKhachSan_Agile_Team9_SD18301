using QuanLyKhachSan.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.View.Manager
{
    public partial class RoomManagement : Form
    {
        List<Room> lstRoom;
        string _idCurrent;
        public RoomManagement()
        {
            InitializeComponent();
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbClass.Items.Add("Standard Room");
            cmbClass.Items.Add("Deluxe Room");
            cmbClass.Items.Add("VIP Room");
            lstRoom = new List<Room>();
            string roomRaw = File.ReadAllText("RoomData.json");
            lstRoom = JsonSerializer.Deserialize<List<Room>>(roomRaw);
            LoadData();
        }

        private void LoadData()
        {
            dtgData.ColumnCount = 4;
            dtgData.Columns[0].Name = "ID";
            dtgData.Columns[1].Name = "Tên phòng";
            dtgData.Columns[2].Name = "Loại phòng";
            dtgData.Columns[3].Name = "Giá phòng";

            dtgData.Rows.Clear();
            for (int i = 0; i < lstRoom.Count; i++)
            {
                dtgData.Rows.Add(lstRoom[i].RoomID, lstRoom[i].RoomName, lstRoom[i].RoomClass, lstRoom[i].Cost);
            }

        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                _idCurrent = dtgData.CurrentRow.Cells[0].Value.ToString();
                lblCurrentID.Text = "Bạn đang thao tác trên \nphòng có ID: " + _idCurrent;
                int rowIndex = dtgData.CurrentCell.RowIndex;
                txtID.Text = dtgData.Rows[rowIndex].Cells[0].Value.ToString();
                txtName.Text = dtgData.Rows[rowIndex].Cells[1].Value.ToString();
                cmbClass.Text = dtgData.Rows[rowIndex].Cells[2].Value.ToString();
                txtCost.Text = dtgData.Rows[rowIndex].Cells[3].Value.ToString();

            }
            catch
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtName.Text = "";
            cmbClass.Text = "";
            txtCost.Text = "";
            txtID.ReadOnly = false;
            _idCurrent = "";
            lblCurrentID.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var a = lstRoom.Where(x => x.RoomID == txtID.Text).FirstOrDefault();
                if (a != null)
                {
                    MessageBox.Show("ID đã tồn tại");
                    return;
                }
                else
                {
                    Room room = new Room();
                    room.RoomID = txtID.Text;
                    room.RoomName = txtName.Text;
                    room.RoomClass = cmbClass.Text;
                    room.Cost = double.Parse(txtCost.Text);
                    lstRoom.Add(room);
                    SaveToFile();
                    LoadData();
                    MessageBox.Show("Thêm thành công");
                }
            }
            catch
            {
                MessageBox.Show("Thêm thất bại");
            }
        }
        public void SaveToFile()
        {
            string roomRaw = JsonSerializer.Serialize(lstRoom);
            File.WriteAllText("RoomData.json", roomRaw);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var a = lstRoom.Where(x => x.RoomID == txtID.Text).FirstOrDefault();
                if (a != null)
                {
                    a.RoomName = txtName.Text;
                    a.RoomClass = cmbClass.Text;
                    a.Cost = double.Parse(txtCost.Text);
                    SaveToFile();
                    LoadData();
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("ID không tồn tại");
                }
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var a = lstRoom.Where(x => x.RoomID == txtID.Text).FirstOrDefault();
                if (a != null)
                {
                    lstRoom.Remove(a);
                    SaveToFile();
                    LoadData();
                    MessageBox.Show("Xóa thành công");
                }
                else
                {
                    MessageBox.Show("ID không tồn tại");
                }
            }
            catch
            {
                MessageBox.Show("Xóa thất bại");
            }
        }
    }
}
