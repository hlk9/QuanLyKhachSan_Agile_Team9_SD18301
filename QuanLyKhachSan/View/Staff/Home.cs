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

        public Home()
        {
            lstRoom = new List<Room>();
            InitializeComponent();
            string raw = File.ReadAllText("RoomData.json");
            lstRoom = JsonSerializer.Deserialize<List<Room>>(raw);
            LoadData();
        }

        public void LoadData()
        {
            int stt = 1;
            Type type = typeof(Room);
            int a = type.GetProperties().Length;
            dtgListRoom.ColumnCount = a;
           
            dtgListRoom.Columns[0].Name = "STT";
            dtgListRoom.Columns[1].Name = "Tên phòng";
            dtgListRoom.Columns[2].Name = "Hạng phòng";
            dtgListRoom.Columns[3].Name = "Trạng thái";
            dtgListRoom.Columns[4].Name = "Giá";
            dtgListRoom.Rows.Clear();
            for (int i=0;i<lstRoom.Count;i++)
            {
                
                dtgListRoom.Rows.Add(stt++, lstRoom[i].RoomName, lstRoom[i].RoomClass, lstRoom[i].Status == true ? "Trống" : "Đang phục vụ", lstRoom[i].Cost);
                if (lstRoom[i].Status == false)
                {
                    dtgListRoom.Rows[i].Cells[3].Style.ForeColor = Color.Red;
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
