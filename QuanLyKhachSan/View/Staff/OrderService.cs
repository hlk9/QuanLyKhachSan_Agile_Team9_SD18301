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
    public partial class OrderService : Form
    {
        private List<Bill> _lstBill = new List<Bill>();
        private List<Services> _lstSer = new List<Services>();
        private List<Room> _lstRoom = new List<Room>();

        public OrderService()
        {
            InitializeComponent();

            string rawData = File.ReadAllText("RoomData.json");
            _lstRoom = JsonSerializer.Deserialize<List<Room>>(rawData);

            string rawBill = File.ReadAllText("BillData.json");
            _lstBill = JsonSerializer.Deserialize<List<Bill>>(rawBill);

            string rawSer = File.ReadAllText("ServiceData.json");
            _lstSer = JsonSerializer.Deserialize<List<Services>>(rawSer);

            loadDaTa();
        }

        private void loadDaTa()
        {
            int stt = 1;
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "STT";
            dataGridView1.Columns[1].Name = "Room ID";
            dataGridView1.Columns[2].Name = "Room Name";
            dataGridView1.Columns[3].Name = "Service Name";
            dataGridView1.Rows.Clear();

            foreach (var x in _lstBill)
            {
                if (x.IsPaid == false)
                {
                    string[] lstSerArr = x.ServiceID;
                    string a = "";
                    for (int i = 0; i < lstSerArr.Length; i++)
                    {
                        var e = _lstSer.FirstOrDefault(f => f.Id == lstSerArr[i]);
                        try
                        {
                            if (e != null)
                            {
                                a += e.Name;
                            }
                        }
                        catch
                        {
                            a = "";
                        }
                    }
                    dataGridView1.Rows.Add(stt++, x.RoomID,
                                        _lstRoom.Where(y => y.RoomID == x.RoomID).Select(z => z.RoomName).FirstOrDefault(),
                                        a);

                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if (row.Cells[3].Value == "")
                        {
                            row.Visible = false;
                        }
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
