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
using System.Text.RegularExpressions;

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

        private bool checkInput()
        {
            int error = 0;
            
            if(txtCost.Text == "")
            {
                errorProvider1.SetError(txtCost, "Không được để trống!!");
                error++;
            }

            if (txtID.Text == "")
            {
                errorProvider1.SetError(txtID, "Không được để trống!!");
                error++;
            }

            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Không được để trống!!");
                error++;
            }


            if (!Regex.IsMatch(txtCost.Text, @"^[0-9]+$"))
            {
                errorProvider1.SetError(txtCost, "Chỉ được nhập số dương");
                error++;
            }

            if (!Regex.IsMatch(txtName.Text, @"[a-zA-Z]+$"))
            {
                errorProvider1.SetError(txtName, "Chỉ được nhập chữ");
                error++;
            }

            if (error == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
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
            txtID.Enabled = false;
            _idWhenClick = dtgSer.Rows[rowIndex].Cells[1].Value.ToString();
            var obj = lstSer.FirstOrDefault(x => x.Id == _idWhenClick);

            txtID.Text = obj.Id;
            txtName.Text = obj.Name;
            txtCost.Text = obj.Cost;
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (checkInput())
        {
            if (txtID.Text == lstSer.Select(x => x.Id).FirstOrDefault())
            {
                MessageBox.Show("Đã có mã này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

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

    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (checkInput())
        {
            var obj = lstSer.FirstOrDefault(x => x.Id == _idWhenClick);

            obj.Id = txtID.Text;
            obj.Name = txtName.Text;
            obj.Cost = txtCost.Text;

            var rawSer = JsonSerializer.Serialize(lstSer);
            File.WriteAllText("ServiceData.json", rawSer);

            MessageBox.Show("Sửa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();

            txtID.Enabled = true;

            txtID.Text = "";
            txtName.Text = "";
            txtCost.Text = "";
        }

    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (checkInput())
        {
            var obj = lstSer.FirstOrDefault(x => x.Id == _idWhenClick);

            lstSer.Remove(obj);

            var rawSer = JsonSerializer.Serialize(lstSer);
            File.WriteAllText("ServiceData.json", rawSer);

            MessageBox.Show("Xóa thành công!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            loadData();

            txtID.Enabled = true;

            txtID.Text = "";
            txtName.Text = "";
            txtCost.Text = "";
        }

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}
}
