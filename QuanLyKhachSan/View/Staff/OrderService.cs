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

        string _idWhenSelect;
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
            int stt = 0;
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
                    if (lstSerArr != null)
                    {

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
            if (_idWhenSelect == "")
            {
                MessageBox.Show("Vui lòng chọn phòng muốn hủy!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn chắc chắn muốn hủy?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < _lstBill.Count; i++)
                    {
                        if (_lstBill[i].RoomID == _idWhenSelect && _lstBill[i].IsPaid == false)
                        {
                            _lstBill[i].ServiceID = null;

                            File.WriteAllText("BillData.json", JsonSerializer.Serialize(_lstBill));
                            MessageBox.Show("Hủy thành công!!");
                            loadDaTa();
                            break;
                        }
                    }
                }
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string roomID, roomName, serviceName;
                int rowIndex = dataGridView1.CurrentRow.Index;
                roomID = dataGridView1.Rows[rowIndex].Cells[1].Value.ToString();
                roomName = dataGridView1.Rows[rowIndex].Cells[2].Value.ToString();
                serviceName = dataGridView1.Rows[rowIndex].Cells[3].Value.ToString();
                _idWhenSelect = roomID;

                label1.Text = "Mã phòng: " + roomID + "--" + " Tên phòng: " + roomName + "--" + " Tên dịch vụ: " + serviceName;
            }
            catch
            {
                _idWhenSelect = "";
                label1.Text = "";
            }

        }
    }
}
