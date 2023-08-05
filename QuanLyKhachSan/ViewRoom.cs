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
    public partial class ViewRoom : Form
    {
        List<Room> listRoom = new List<Room>();

        string _RoomId;
        public ViewRoom()
        {
            InitializeComponent();
            string rawData = File.ReadAllText("RoomData.json");
            listRoom = JsonSerializer.Deserialize<List<Room>>(rawData);
            loadData();
        }

        public void loadData()
        {
            int stt = 1;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Room ID";
            dataGridView1.Columns[2].Name = "Room Class";
            dataGridView1.Columns[3].Name = "Room Name";
            dataGridView1.Columns[4].Name = "Cost";
            dataGridView1.Rows.Clear();

            foreach (var room in listRoom)
            {
                dataGridView1.Rows.Add(stt++, room.RoomID, room.RoomClass, room.RoomName, room.Cost);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            if (rowIndex < 0)
            {
                return;
            }
            else
            {
                _RoomId = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();

                var obj = listRoom.FirstOrDefault(x => x.RoomID == _RoomId);
                lblShow.Text = $"Mã Phòng: {obj.RoomID} -- Tên Phòng: {obj.RoomName} -- Loại Phòng: {obj.RoomClass} -- Giá: {obj.Cost}";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
