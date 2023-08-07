using QuanLyKhachSan.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using QuanLyKhachSan.View.Both;

namespace QuanLyKhachSan.View.Manager
{
    public partial class HomeManager : Form
    {
        List<Bill> lstBill;
        List<Customer> lstCus;
        List<Room> lstRoom;
        public HomeManager()
        {
            InitializeComponent();
            lstBill = new List<Bill>();
            lstCus = new List<Customer>();
            lstRoom = new List<Room>();
            string billRaw = File.ReadAllText("BillData.json");
            lstBill = JsonSerializer.Deserialize<List<Bill>>(billRaw);
            string cusRaw = File.ReadAllText("CustomerData.json");
            lstCus = JsonSerializer.Deserialize<List<Customer>>(cusRaw);
            string roomRaw = File.ReadAllText("RoomData.json");
            lstRoom = JsonSerializer.Deserialize<List<Room>>(roomRaw);
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;

            dtgData.ColumnCount = 6;

            dtgData.Columns[0].Name = "STT";
            dtgData.Columns[1].Name = "Tên phòng";
            dtgData.Columns[2].Name = "Tên khách hàng";
            dtgData.Columns[3].Name = "Thành tiền";
            dtgData.Columns[4].Name = "ID KH";
            dtgData.Columns[5].Name = "ID Room";
            dtgData.Columns[4].Visible = false;
            dtgData.Columns[5].Visible = false;
            dtgData.Rows.Clear();
            for (int i = 0; i < lstBill.Count; i++)
            {


                if (lstBill[i].IsPaid == false)
                {
                    var room = lstRoom.FirstOrDefault(x => x.RoomID == lstBill[i].RoomID);
                    var customer = lstCus.FirstOrDefault(x => x.IdCustomer == lstBill[i].IdCustomer);
                    dtgData.Rows.Add(stt++, room.RoomName, customer.Name, lstBill[i].TotalPay(), customer.IdCustomer, room.RoomID);
                }


            }
        }

        private void dtgData_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                int rowIndex = dtgData.CurrentCell.RowIndex;
                string roomID = dtgData.Rows[rowIndex].Cells[5].Value.ToString();
                string cusID = dtgData.Rows[rowIndex].Cells[4].Value.ToString();
                var room = lstRoom.FirstOrDefault(x => x.RoomID == roomID);
                var customer = lstCus.FirstOrDefault(x => x.IdCustomer == cusID);
                txtRoomID.Text = room.RoomID;
                txtRoomName.Text = room.RoomName;
                txtRoomClass.Text = room.RoomClass;
                txtCost.Text = room.Cost.ToString();
                txtCusName.Text = customer.Name;
                txtPhone.Text = customer.PhoneNumer;

            }
            catch
            {

            }
        }

        private void btnRoomManager_Click(object sender, EventArgs e)
        {
            RoomManagement roomManagement = new RoomManagement();
            roomManagement.ShowDialog();

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Report report = new Report();
            report.ShowDialog();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Booking_History his = new Booking_History();
            his.ShowDialog();
        }
    }
}
