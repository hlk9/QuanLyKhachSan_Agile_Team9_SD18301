using QuanLyKhachSan.Modal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan.View.Staff
{
    public partial class FormCheckOutRoom : Form
    {
        List<Room> lstRoom;
        List<Bill> lstBill;
        List<Customer> lstCustomer;
        List<Services> lstService;
        string _idBill;
        string _idRoom;
        string _idCustomer;
        public FormCheckOutRoom()
        {
            lstRoom = new List<Room>();
            lstBill = new List<Bill>();
            lstCustomer = new List<Customer>();
            lstService = new List<Services>();
            InitializeComponent();
            string raw = File.ReadAllText("RoomData.json");
            lstRoom = JsonSerializer.Deserialize<List<Room>>(raw);
            string rawBill = File.ReadAllText("BillData.json");
            lstBill = JsonSerializer.Deserialize<List<Bill>>(rawBill);
            string rawCus = File.ReadAllText("CustomerData.json");
            lstCustomer = JsonSerializer.Deserialize<List<Customer>>(rawCus);
            string rawSer = File.ReadAllText("ServiceData.json");
            lstService = JsonSerializer.Deserialize<List<Services>>(rawSer);
            LoadData();
        }
        public void LoadData()
        {
            int stt = 1;
            Type type = typeof(Room);
            int a = type.GetProperties().Length;
            dtgRoom.ColumnCount = a + 2;

            dtgRoom.Columns[0].Name = "STT";
            dtgRoom.Columns[1].Name = "Tên phòng";
            dtgRoom.Columns[2].Name = "Hạng phòng";
            dtgRoom.Columns[3].Name = "Trạng thái";
            dtgRoom.Columns[4].Name = "Giá";
            dtgRoom.Columns[5].Name = "ID Phòng";
            dtgRoom.Columns[5].Visible = false;
            dtgRoom.Columns[6].Name = "ID Bill";
            dtgRoom.Columns[6].Visible = false;
            dtgRoom.Rows.Clear();
            for (int i = 0; i < lstRoom.Count; i++)
            {
                try
                {


                    if (lstRoom[i].Status == false)
                    {

                        var bill = lstBill.FirstOrDefault(x => x.RoomID == lstRoom[i].RoomID && x.IsPaid == false);
                        if (bill != null)
                        {
                            dtgRoom.Rows.Add(stt++, lstRoom[i].RoomName, lstRoom[i].RoomClass, lstRoom[i].Status == true ? "Trống" : "Đang phục vụ", lstRoom[i].Cost, lstRoom[i].RoomID, bill.IdBill);
                            dtgRoom.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                        }
                    }
                }
                catch
                { }






            }
            //(from ojb in lstRoom 
            //where ojb.RoomID == ID 
            //select ojb).ToList().Foreach(x=>x.
        }

        private void dtgRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                _idBill = dtgRoom.Rows[e.RowIndex].Cells[6].Value.ToString();
                _idRoom = dtgRoom.Rows[e.RowIndex].Cells[5].Value.ToString();
                lblCurrentRoom.Text = "Đang chọn phòng " + dtgRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
                lblRoom.Text = "Phòng: " + dtgRoom.Rows[e.RowIndex].Cells[1].Value.ToString();
                var bill = lstBill.FirstOrDefault(x => x.IdBill == _idBill && x.IsPaid == false);
                if (bill != null)
                {                   

                    txtFrom.Text = DateTime.Parse(bill.BookingDate.ToString()).ToString("dd-MM-yyyy");
                    txtTo.Text = DateTime.Parse(bill.CheckOutDate.ToString()).ToString("dd-MM-yyyy");
                    var usr = lstCustomer.FirstOrDefault(x => x.IdCustomer == bill.IdCustomer);
                    lblName.Text = "Họ tên: " + usr.Name;
                    lblTotalCost.Text = bill.TotalPay().ToString();
                    //MessageBox.Show(_idRoom + _idBill);
                }

            }
            catch
            { }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < lstBill.Count; i++)
                {
                    if (lstBill[i].IdBill == _idBill)
                    {
                        lstBill[i].IsPaid = true;
                    }
                }
                string raw = JsonSerializer.Serialize(lstBill);
                string fileData = "BillData.json";
                File.WriteAllText(fileData, raw);

                for (int i = 0; i < lstRoom.Count; i++)
                {
                    if (lstRoom[i].RoomID == _idRoom)
                    {
                        lstRoom[i].Status = true;
                    }
                }
                string rawRoom = JsonSerializer.Serialize(lstRoom);
                string fileDataRoom = "RoomData.json";
                File.WriteAllText(fileDataRoom, rawRoom);
                MessageBox.Show("Thanh toán thành công");
                LoadData();
            }
            catch
            {
                MessageBox.Show("ĐÃ XẢY RA LỖI TRONG QUÁ TRÌNH THANH TOÁN");
            }
        }
    }
}
