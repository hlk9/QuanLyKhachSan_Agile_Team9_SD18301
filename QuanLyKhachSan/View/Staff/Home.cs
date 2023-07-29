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

namespace QuanLyKhachSan.View.Staff
{
    public partial class Home : Form
    {
        List<Room> lstRoom;

        public Home()
        {
            lstRoom = new List<Room>();
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
