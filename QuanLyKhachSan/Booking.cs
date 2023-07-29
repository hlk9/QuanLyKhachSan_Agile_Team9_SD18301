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

        string _roomID;

        public Booking()
        {
            InitializeComponent();
            string rawData = File.ReadAllText("RoomData.json");
            listRoom = JsonSerializer.Deserialize<List<Room>>(rawData);
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

            if (rowIndex < 0)
            {
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
    }
}
