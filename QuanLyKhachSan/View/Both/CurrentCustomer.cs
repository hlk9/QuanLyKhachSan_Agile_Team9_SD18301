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

namespace QuanLyKhachSan.View.Both
{
    public partial class CurrentCustomer : Form
    {
        List<Bill> lstBill;
        List<Customer> lstCustomer;
        List<Room> lstRoom;
        public CurrentCustomer()
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
                if (bill.IsPaid == false)
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
    }
}
