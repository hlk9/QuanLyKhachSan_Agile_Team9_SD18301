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

namespace QuanLyKhachSan
{
    public partial class StaffManage : Form
    {
        private List<Staff> lstStaff = new List<Staff>();

        string _idWWhenClick;
        public StaffManage()
        {
            InitializeComponent();
            string rawStaff = File.ReadAllText("StaffData.json");
            lstStaff = JsonSerializer.Deserialize<List<Staff>>(rawStaff);
            loadData();
        }

        private void loadData()
        {
            int stt = 1;
            dtgStaff.ColumnCount = 8;
            dtgStaff.Columns[0].Name = "STT";
            dtgStaff.Columns[1].Name = "Id";
            dtgStaff.Columns[2].Name = "Name";
            dtgStaff.Columns[3].Name = "Old";
            dtgStaff.Columns[4].Name = "Phone";
            dtgStaff.Columns[5].Name = "Email";
            dtgStaff.Columns[6].Name = "Address";
            dtgStaff.Columns[7].Name = "Position";
            dtgStaff.Rows.Clear();

            foreach (var staff in lstStaff)
            {
                dtgStaff.Rows.Add(stt++, staff.Id, staff.Name, staff.Old, staff.Phone, staff.Email, staff.Address, staff.Position);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();

            staff.Id = txtID.Text;
            staff.Name = txtName.Text;
            staff.Phone = txtPhone.Text;
            staff.Email = txtEmail.Text;
            staff.Old = txtOld.Text;
            staff.Address = rtxtAddress.Text;
            staff.Position = txtPos.Text;

            lstStaff.Add(staff);

            string rawst = JsonSerializer.Serialize(lstStaff);
            File.WriteAllText("StaffData.json", rawst);

            MessageBox.Show("Thêm nhân viên thành công!!");

            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var obj = lstStaff.FirstOrDefault(x => x.Id == _idWWhenClick);
            obj.Id = txtID.Text;
            obj.Name = txtName.Text;
            obj.Phone = txtPhone.Text;
            obj.Email = txtEmail.Text;
            obj.Old = txtOld.Text;
            obj.Address = rtxtAddress.Text;
            obj.Position = txtPos.Text;

            var rawst = JsonSerializer.Serialize(lstStaff);
            File.WriteAllText("StaffData.json", rawst);

            MessageBox.Show("Sửa thành công!!!");

            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var obj = lstStaff.FirstOrDefault(x => x.Id == _idWWhenClick);

            lstStaff.Remove(obj);

            string rawst = JsonSerializer.Serialize( lstStaff);
            File.WriteAllText("StaffData.json", rawst);

            MessageBox.Show("Xóa thành công!!!");

            loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0 || rowIndex == lstStaff.Count)
            {
                return;
            }
            else
            {
                _idWWhenClick = dtgStaff.Rows[rowIndex].Cells[1].Value.ToString();

                var obj = lstStaff.FirstOrDefault(x => x.Id == _idWWhenClick);
                txtID.Text = obj.Id;
                txtName.Text = obj.Name;
                txtPhone.Text = obj.Phone;
                txtEmail.Text = obj.Email;
                txtOld.Text = obj.Old;
                rtxtAddress.Text = obj.Address;
                txtPos.Text = obj.Position;
            }
        }
    }
}
