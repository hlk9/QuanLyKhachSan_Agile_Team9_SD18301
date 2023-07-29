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

namespace QuanLyKhachSan
{
    public partial class ViewRoomSatus : Form
    {
        List<Room> listRoom = new List<Room>();

        public ViewRoomSatus()
        {
            InitializeComponent();
            string rawData = File.ReadAllText("RoomData.json");
            listRoom = JsonSerializer.Deserialize<List<Room>>(rawData);
            loadData();
        }

        public void loadData()
        {
            int stt = 1;
            dtgViewstatus.ColumnCount = 4;
            dtgViewstatus.Columns[0].Name = "STT";
            dtgViewstatus.Columns[1].Name = "Room ID";
            dtgViewstatus.Columns[2].Name = "Room Name";
            dtgViewstatus.Columns[3].Name = "Status";
            dtgViewstatus.Rows.Clear();

            foreach (var room in listRoom)
            {
                dtgViewstatus.Rows.Add(stt++, room.RoomID, room.RoomName, (room.Status == true ? "Chưa đặt" : "Đã đặt"));
                foreach (DataGridViewRow row in dtgViewstatus.Rows)
                {
                    if (row.Cells[3].Value == "Chưa đặt")
                    {
                        row.Visible = false;
                    }
                }
            }
        }

        private void dtgViewstatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                var _RoomId = dtgViewstatus.Rows[rowIndex].Cells[1].Value.ToString();

                var obj = listRoom.FirstOrDefault(x => x.RoomID == _RoomId);
                lblShow.Text = $"Mã Phòng: {obj.RoomID} -- Tên Phòng: {obj.RoomName} -- {(obj.Status == true ? "Chưa đặt" : "Đã đặt")}";
            }
        }
    }
}
