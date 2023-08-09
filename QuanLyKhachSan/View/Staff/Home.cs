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
    public partial class Home : Form
    {
        List<Room> lstRoom;
        List<Bill> lstBill;
        List<Customer> lstCustomer;
        string _idWhenClick;
        string _nameWhenClick;
        public Home()
        {
            lstRoom = new List<Room>();
            lstBill = new List<Bill>();
            lstCustomer = new List<Customer>();
            InitializeComponent();
            string raw = File.ReadAllText("RoomData.json");
            lstRoom = JsonSerializer.Deserialize<List<Room>>(raw);
            //string rawBill = File.ReadAllText("BillData.json");
            //lstBill = JsonSerializer.Deserialize<List<Bill>>(rawBill);
            //string rawCus = File.ReadAllText("CustomerData.json");
            //lstCustomer = JsonSerializer.Deserialize<List<Customer>>(rawCus);


            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;
            Type type = typeof(Room);
            int a = type.GetProperties().Length;
            dtgListRoom.ColumnCount = a + 1;

            dtgListRoom.Columns[0].Name = "STT";
            dtgListRoom.Columns[1].Name = "Tên phòng";
            dtgListRoom.Columns[2].Name = "Hạng phòng";
            dtgListRoom.Columns[3].Name = "Trạng thái";
            dtgListRoom.Columns[4].Name = "Giá";
            dtgListRoom.Columns[5].Name = "ID";
            dtgListRoom.Columns[5].Visible = false;
            dtgListRoom.Rows.Clear();
            for (int i = 0; i < lstRoom.Count; i++)
            {

                dtgListRoom.Rows.Add(stt++, lstRoom[i].RoomName, lstRoom[i].RoomClass, lstRoom[i].Status == true ? "Trống" : "Đang phục vụ", lstRoom[i].Cost, lstRoom[i].RoomID);
                if (lstRoom[i].Status == false)
                {
                    dtgListRoom.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                }


            }
            //(from ojb in lstRoom 
            //where ojb.RoomID == ID 
            //select ojb).ToList().Foreach(x=>x.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Cancel_Room a = new Cancel_Room();
            a.ShowDialog();
        }

        private void dtgListRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                _nameWhenClick = dtgListRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
                _idWhenClick = dtgListRoom.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblCurrentName.Text = "Đang chọn: " + _nameWhenClick;
            }
            catch
            { }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            FormCheckOutRoom a = new FormCheckOutRoom();
            a.ShowDialog();

        }

        private void A_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void btnDatphong_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking();
            booking.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ViewRoomSatus viewRoomSatus = new ViewRoomSatus();
            viewRoomSatus.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OrderService orderService = new OrderService();
            orderService.ShowDialog();
        }
    }
}
