using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Modal
{
    internal class Staff
    {
        private string id;
        private string name;
        private string old;
        private string phone;
        private string address;
        private string position;
        private string email;


        public Staff()
        {
            
        }

        public Staff(string id, string name, string old, string phone, string address, string position, string email)
        {
            this.id = id;
            this.name = name;
            this.old = old;
            this.phone = phone;
            this.address = address;
            this.position = position;
            this.email = email;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Old { get => old; set => old = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Address { get => address; set => address = value; }
        public string Position { get => position; set => position = value; }
        public string Email { get => email; set => email = value; }
    }
}
