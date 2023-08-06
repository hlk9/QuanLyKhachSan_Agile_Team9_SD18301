using System;
using System.Text.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyKhachSan.Modal;

namespace QuanLyKhachSan
{
    public partial class Service : Form
    {
        private List<Services> lstSer = new List<Services>();

        string _idWhenClick;
        public Service()
        {
            InitializeComponent();
            var rawSer = File.ReadAllText("ServiceData.json");
            lstSer = JsonSerializer.Deserialize<List<Services>>(rawSer);
            loadData();
        }

        private void loadData()
        {
            int stt = 1;
            dtgSer.ColumnCount = 4;

            dtgSer.Columns[0].Name = "STT";
            dtgSer.Columns[1].Name = "Service ID";
            dtgSer.Columns[2].Name = "Service Name";
            dtgSer.Columns[3].Name = "Service Cost";
            dtgSer.Rows.Clear();

            foreach (var x in lstSer)
            {
                dtgSer.Rows.Add(stt++, x.Id, x.Name, x.Cost);
            }
        }

        private void dtgSer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _idWhenClick = dtgSer.Rows[rowIndex].Cells[1].Value.ToString();
                var obj = lstSer.FirstOrDefault(x => x.Id == _idWhenClick);

                txtID.Text = obj.Id;
                txtName.Text = obj.Name;
                txtCost.Text = obj.Cost;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Services ser = new Services();

            ser.Id = txtID.Text;
            ser.Name = txtName.Text;
            ser.Cost = txtCost.Text;

            lstSer.Add(ser);

            var rawSer = JsonSerializer.Serialize(lstSer);
            File.WriteAllText("ServiceData.json", rawSer);

            MessageBox.Show("Thêm thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var obj = lstSer.FirstOrDefault(x => x.Id == _idWhenClick);

            obj.Id = txtID.Text;
            obj.Name = txtName.Text;
            obj.Cost = txtCost.Text;

            var rawSer = JsonSerializer.Serialize(lstSer);
            File.WriteAllText("ServiceData.json", rawSer);

            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var obj = lstSer.FirstOrDefault(x => x.Id == _idWhenClick);

            lstSer.Remove(obj);

            var rawSer = JsonSerializer.Serialize(lstSer);
            File.WriteAllText("ServiceData.json", rawSer);

            MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
