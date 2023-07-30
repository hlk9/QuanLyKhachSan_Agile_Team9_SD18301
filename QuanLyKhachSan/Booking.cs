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

namespace QuanLyKhachSan
{
    public partial class Booking : Form
    {
        List<Room> listRoom = new List<Room>();

        List<Bill> listBill = new List<Bill>();

        List<Customer> listCus = new List<Customer>();

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
            loadData();
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
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dtgDatPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0 || dtgDatPhong.Rows[rowIndex].Cells[4].Value == "Đã đặt")
            {
                txtRoomID.Text = "";
                txtRoomName.Text = "";
                txtRoomClass.Text = "";
                txtCost.Text = "";
                return;
            }
            else
            {
                _roomID = dtgDatPhong.Rows[rowIndex].Cells[1].Value.ToString();

                var obj = listRoom.FirstOrDefault(x => x.RoomID == _roomID);
                txtRoomID.Text = obj.RoomID.ToString();
                txtRoomName.Text = obj.RoomName.ToString();
                txtRoomClass.Text = obj.RoomClass.ToString();
                txtCost.Text = obj.Cost.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Customer cus = new Customer();
            Bill bill = new Bill();
            Room room = new Room();

            bill.BookingDate = DateTime.Parse(dtpCheckIn.Text);
            bill.CheckOutDate = DateTime.Parse(dtpCheckOut.Text);
            bill.TotalCost = double.Parse(txtCost.Text);

            cus.Name = txtName.Text;
            cus.Email = txtEmail.Text;
            cus.PhoneNumer = txtPhone.Text;
            cus.CMND = txtCMND.Text;

            try
            {
                listBill.Add(bill);
                listCus.Add(cus);

                (from ojb in listRoom
                 where ojb.RoomID == txtRoomID.Text
                 select ojb).ToList().ForEach(x => x.Status = false);

                string rawBill = JsonSerializer.Serialize(listBill);
                File.WriteAllText("BillData.json", rawBill);

                string rawCus = JsonSerializer.Serialize(listCus);
                File.WriteAllText("CustomerData.json", rawCus);

                loadData();

                MessageBox.Show("Đặt phòng thành công!!");
            }
            catch { }

        }
    }
}
