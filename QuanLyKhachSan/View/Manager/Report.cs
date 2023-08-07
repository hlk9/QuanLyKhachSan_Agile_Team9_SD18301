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
    public partial class Report : Form
    {
        List<Bill> lstBill;
        List<Customer> lstCustomer;
        List<Room> lstRoom;

        public Report()
        {

            InitializeComponent();
            lstBill = new List<Bill>();
            lstCustomer = new List<Customer>();
            string rawBill = File.ReadAllText("BillData.json");
            lstBill = JsonSerializer.Deserialize<List<Bill>>(rawBill);
            string rawCustomer = File.ReadAllText("CustomerData.json");
            lstCustomer = JsonSerializer.Deserialize<List<Customer>>(rawCustomer);
            string rawRoom = File.ReadAllText("RoomData.json");
            lstRoom = JsonSerializer.Deserialize<List<Room>>(rawRoom);
            InitDataGrid();
        }

        public void InitDataGrid()
        {

            dtgData.ColumnCount = 8;
            dtgData.Columns[0].Name = "Mã hóa đơn";
            dtgData.Columns[1].Name = "Mã khách hàng";
            dtgData.Columns[2].Name = "Mã Phòng";
            dtgData.Columns[3].Name = "Tên Phòng";
            dtgData.Columns[4].Name = "Giá Phòng";
            dtgData.Columns[5].Name = "Tên Khách hàng";
            dtgData.Columns[6].Name = "Tổng Bill";
            dtgData.Columns[7].Name = "Số ĐT";
            dtgData.Columns[0].Visible = false;
            dtgData.Columns[1].Visible = false;
            dtgData.Columns[2].Visible = false;
            dtgData.Rows.Clear();
        }
        private void dateBegin_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                double total = 0;
                InitDataGrid();
                string beginDate = dateBegin.Value.ToString("yyyy-MM-dd");
                string endDate = dateEnd.Value.ToString("yyyy-MM-dd");

                if (beginDate != "" && endDate != "")
                {
                    var lst = lstBill.Where(x => x.CheckOutDate >= DateTime.Parse(beginDate) && x.CheckOutDate <= DateTime.Parse(endDate) && x.IsPaid == true).ToList();

                    foreach (var x in lst)
                    {

                        var cus = lstCustomer.FirstOrDefault(c => c.IdCustomer == x.IdCustomer); ;
                        if (cus != null)
                        {
                            var r = lstRoom.FirstOrDefault(c => c.RoomID == x.RoomID);
                            dtgData.Rows.Add(x.IdBill, cus.IdCustomer, x.RoomID, r.RoomName, r.Cost, cus.Name, x.TotalPay(), cus.PhoneNumer);
                            total += x.TotalPay();
                        }

                    }
                    lblTotal.Text = "Tổng: " + total;
                }
                else
                {
                    lblTotal.Text = "No data";
                }

            }
            catch
            {

            }
        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dtgData.CurrentCell.RowIndex;
                txtRoomName.Text = dtgData.Rows[rowIndex].Cells[3].Value.ToString();
                txtCost.Text = dtgData.Rows[rowIndex].Cells[4].Value.ToString();
                txtCusName.Text = dtgData.Rows[rowIndex].Cells[5].Value.ToString();
                txtPhone.Text = dtgData.Rows[rowIndex].Cells[7].Value.ToString();
            }
            catch
            {
                txtPhone.Text = "";
                txtCusName.Text = "";
                txtCost.Text = "";
                txtRoomName.Text = "";
            }
        }
    }
}
