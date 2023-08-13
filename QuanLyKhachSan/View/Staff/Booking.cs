using System.Text.Json;
using System;
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
    public partial class Booking : Form
    {
        List<Room> listRoom = new List<Room>();

        List<Bill> listBill = new List<Bill>();

        List<Customer> listCus = new List<Customer>();

        List<Services> listSer = new List<Services>();

        string _roomID;

        public Booking()
        {
            InitializeComponent();
            string rawData = File.ReadAllText("RoomData.json");
            listRoom = JsonSerializer.Deserialize<List<Room>>(rawData);

            string rawBill = File.ReadAllText("BillData.json");
            listBill = JsonSerializer.Deserialize<List<Bill>>(rawBill);

            string rawCus = File.ReadAllText("CustomerData.json");
            listCus = JsonSerializer.Deserialize<List<Customer>>(rawCus);

            string rawService = File.ReadAllText("ServiceData.json");
            listSer = JsonSerializer.Deserialize<List<Services>>(rawService);

            loadData();
        }

        private bool checkInput()
        {
            int error = 0;

            if (!Regex.IsMatch(txtEmail.Text, @"[a-zA-Z0-9]+@[a-zA-Z]{1,5}\.[a-z]{2,3}$") && txtEmail.Text != "")
            {
                errorProvider1.SetError(txtEmail, "Định dạng Email không đúng");
                error++;
            }
            else
            {
                errorProvider1.SetError(txtEmail, "");
            }

            if (!Regex.IsMatch(txtPhone.Text, @"(09|08|03)[0-9]{8}$"))
            {
                errorProvider1.SetError(txtPhone, "Định dạng số ĐT không đúng");
                error++;
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
            }

            if (txtRoomID.Text == "")
            {
                errorProvider1.SetError(txtRoomID, "Không được để trống!");
                error++;
            }
            else
            {
                errorProvider1.SetError(txtRoomID, "");
            }

            if (txtName.Text == "")
            {
                errorProvider1.SetError(txtName, "Không được để trống!");
                error++;
            }
            else
            {
                errorProvider1.SetError(txtName, "");
            }

            if (txtCMND.Text == "")
            {
                errorProvider1.SetError(txtCMND, "Không được để trống!");
                error++;
            }
            else
            {
                errorProvider1.SetError(txtCMND, "");
            }

            if (txtPhone.Text == "")
            {
                errorProvider1.SetError(txtPhone, "Không được để trống!");
                error++;
            }
            else
            {
                errorProvider1.SetError(txtPhone, "");
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

        public void loadData()
        {
            int stt = 1;
            dtgDatPhong.ColumnCount = 6;
            dtgDatPhong.Columns[0].Name = "STT";
            dtgDatPhong.Columns[1].Name = "Room ID";
            dtgDatPhong.Columns[2].Name = "Room Class";
            dtgDatPhong.Columns[3].Name = "Room Name";
            dtgDatPhong.Columns[4].Name = "Status";
            dtgDatPhong.Columns[5].Name = "Cost";
            dtgDatPhong.Rows.Clear();

            foreach (var room in listRoom)
            {
                dtgDatPhong.Rows.Add(stt++, room.RoomID, room.RoomClass, room.RoomName, (room.Status == true ? "Chưa đặt" : "Đã đặt"), room.Cost);
                foreach (DataGridViewRow row in dtgDatPhong.Rows)
                {
                    if (row.Cells[4].Value == "Đã đặt")
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtgDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0)
            {
                txtRoomID.Text = "";
                return;
            }
            else
            {
                _roomID = dtgDatPhong.Rows[rowIndex].Cells[1].Value.ToString();

                var obj = listRoom.FirstOrDefault(x => x.RoomID == _roomID);
                lblHienThi.Text = $"Mã Phòng: {obj.RoomID} -- Tên Phòng: {obj.RoomName} -- Loại Phòng: {obj.RoomClass} -- Giá: {obj.Cost}";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                string[] arrRoom = txtRoomID.Text.Split(',');
                string[] arrService = txtDv.Text.Split(",");

                for (int a = 0; a < arrRoom.Length; a++)
                {
                    var z = listRoom.FirstOrDefault(af => af.RoomName == arrRoom[a]);

                    if (z == null)
                    {
                        MessageBox.Show($"Không có phòng này {arrRoom[a]}");
                        return;
                    }
                }

                if (txtDv.Text != "")
                {
                    for (int b = 0; b < arrService.Length; b++)
                    {
                        var t = listSer.FirstOrDefault(af => af.Id == arrService[b]);

                        if (t == null)
                        {
                            MessageBox.Show($"Không có dịch vụ này {arrService[b]}");
                            return;
                        }
                    }
                }

                Customer cus = new Customer();


                cus.IdCustomer = Guid.NewGuid().ToString();
                cus.Name = txtName.Text;
                cus.Email = txtEmail.Text;
                cus.PhoneNumer = txtPhone.Text;
                cus.CMND = txtCMND.Text;

                for (int i = 0; i < arrRoom.Length; i++)
                {
                    var x = listRoom.FirstOrDefault(a => a.RoomName == arrRoom[i]);
                    if (x != null)
                    {
                        Bill bill = new Bill();
                        bill.IdBill = Guid.NewGuid().ToString();
                        bill.BookingDate = DateTime.Parse(dtpCheckIn.Text);
                        bill.CheckOutDate = DateTime.Parse(dtpCheckOut.Text);
                        bill.TotalCost = double.Parse(x.Cost.ToString());
                        bill.RoomID = x.RoomID;
                        if (arrService.Length > 0)
                        {
                            bill.ServiceID = arrService;
                        }
                        bill.IdCustomer = cus.IdCustomer.ToString();
                        try
                        {
                            listBill.Add(bill);
                            listCus.Add(cus);

                            for (int y = 0; y < listRoom.Count; y++)
                            {
                                if (listRoom[y].RoomID == bill.RoomID)
                                {
                                    listRoom[y].Status = false;
                                    MessageBox.Show("Đặt phòng " + listRoom[y].RoomName + " thành công!!");
                                    continue;
                                }
                            }

                        }
                        catch { }
                    }
                }

                string rawBill = JsonSerializer.Serialize(listBill);
                File.WriteAllText("BillData.json", rawBill);

                string rawCus = JsonSerializer.Serialize(listCus);
                File.WriteAllText("CustomerData.json", rawCus);

                string rawRoom = JsonSerializer.Serialize(listRoom);
                File.WriteAllText("RoomData.json", rawRoom);

                loadData();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRoomID.Clear();
            txtDv.Clear();
            txtCMND.Clear();
            txtName.Clear();
            txtPhone.Clear();
            rtxtNote.Clear();
            txtEmail.Clear();
        }

        //private bool checkInput()
        //{
        //    int error = 0;
        //    var checkBox =
        //}
    }
}
