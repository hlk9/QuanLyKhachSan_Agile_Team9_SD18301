using QuanLyKhachSan.Modal;
using QuanLyKhachSan.View.Manager;
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
    public partial class Login : Form
    {
        List<User> lstUser = new List<User>();
        public Login()
        {
            InitializeComponent();
            string filePath = "UserData.json";
            string raw = File.ReadAllText(filePath);
            lstUser = JsonSerializer.Deserialize<List<User>>(raw);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                User usr = lstUser.FirstOrDefault(x => x.UserName == txtUserName.Text);
                if (usr != null)
                {
                    if(txtPassword.Text == usr.Password)
                    {
                        string a = usr.Role[0];
                        if (usr.Role[0].Contains("Staff"))
                        {
                            QuanLyKhachSan.View.Staff.Home staffHome = new View.Staff.Home();
                            staffHome.Show();
                            staffHome.FormClosed += StaffHome_FormClosed;
                            this.Hide();
                        }
                        else//for manager or someone else
                        {
                            HomeManager mng = new HomeManager();
                            mng.Show();
                            mng.FormClosed += StaffHome_FormClosed;
                            this.Hide();
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng");
                    }    
                        
                }
            }
            catch
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }

        private void StaffHome_FormClosed(object? sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
