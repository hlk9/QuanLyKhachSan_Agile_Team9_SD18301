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

namespace QuanLyKhachSan.View.Staff
{
    public partial class Cancel_Room : Form
    {
        List<Room> lstRoom;
        List<Bill> lstBill;
        List<Customer> lstCustomer;
        string idRoom;
        public Cancel_Room()
        {
            lstRoom = new List<Room>();
            lstBill = new List<Bill>();
            lstCustomer = new List<Customer>();
            InitializeComponent();
            string raw = File.ReadAllText("RoomData.json");
            lstRoom = JsonSerializer.Deserialize<List<Room>>(raw);
            string rawBill = File.ReadAllText("BillData.json");
            lstBill = JsonSerializer.Deserialize<List<Bill>>(rawBill);
            string rawCustomer = File.ReadAllText("CustomerData.json");
            lstCustomer = JsonSerializer.Deserialize<List<Customer>>(rawCustomer);
            LoadData();

        }

        public void LoadData()
        {
            dtgData.ColumnCount = 7;
            dtgData.Columns[0].Name = "Mã hóa đơn";
            dtgData.Columns[1].Name = "Mã khách hàng";
            dtgData.Columns[2].Name = "Mã Phòng";
            dtgData.Columns[3].Name = "Tên Phòng";
            dtgData.Columns[4].Name = "Giá Phòng";
            dtgData.Columns[5].Name = "Tên Khách hàng";
            dtgData.Columns[6].Name = "Số ĐT";
            dtgData.Rows.Clear();

            foreach (Bill bill in lstBill)
            {
                if (bill.IsPaid == true)
                {

                    foreach (Customer customer in lstCustomer)
                    {
                        if (bill.IdCustomer == customer.IdCustomer)
                        {
                            foreach (Room room in lstRoom)
                            {
                                if (bill.RoomID == room.RoomID)
                                {
                                    dtgData.Rows.Add(bill.IdBill, bill.IdCustomer, bill.RoomID, room.RoomName, room.Cost, customer.Name, customer.PhoneNumer);
                                }
                            }
                        }
                    }

                }
            }



        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string tenPhong, maPhong, giaPhong, tenKhachHang, soDienThoai;
                int rowIndex = dtgData.CurrentRow.Index;
                maPhong = dtgData.Rows[rowIndex].Cells[2].Value.ToString();
                tenPhong = dtgData.Rows[rowIndex].Cells[3].Value.ToString();
                giaPhong = dtgData.Rows[rowIndex].Cells[4].Value.ToString();
                tenKhachHang = dtgData.Rows[rowIndex].Cells[5].Value.ToString();
                soDienThoai = dtgData.Rows[rowIndex].Cells[6].Value.ToString();
                idRoom = maPhong;
                lblHienThi.Text = "Mã Phòng: " + maPhong + " - " + "Tên Phòng: " + tenPhong + " - " + "Giá Phòng: " + giaPhong + " - " + "Tên Khách Hàng: " + tenKhachHang + " - " + "Số Điện Thoại: " + soDienThoai;
            }
            catch
            {
                lblHienThi.Text = "";
                idRoom = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (idRoom == "")
            {
                MessageBox.Show("Vui lòng chọn phòng cần huỷ đặt trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult re = MessageBox.Show("Bạn có chắc muốn huỷ đặt phòng có mã " + idRoom + " không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (re == DialogResult.Yes)
                {
                    for (int i = 0; i < lstRoom.Count; i++)
                    {
                        if (lstRoom[i].RoomID == idRoom)
                        {
                            lstRoom[i].Status = true;
                            for (int j = 0; j < lstBill.Count; j++)
                            {
                                if (lstBill[j].RoomID == idRoom)
                                {
                                    lstBill.Remove(lstBill[j]);
                                    File.WriteAllText("BillData.json", JsonSerializer.Serialize(lstBill));
                                    File.WriteAllText("RoomData.json", JsonSerializer.Serialize(lstRoom));
                                    MessageBox.Show("Xoá thành công");
                                    LoadData();
                                    break;
                                }

                            }
                            break;
                        }
                    }

                }
            }


        }
    }
}
