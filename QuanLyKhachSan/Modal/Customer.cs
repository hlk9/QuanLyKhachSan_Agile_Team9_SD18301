using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Modal
{
    internal class Customer
    {
        private string idCustomer;
        private string name;
        private string address;
        private string cMND;
        private string phoneNumer;
        private string email;

    
        public Customer()
        {
            
        }

        public Customer(string idCustomer, string name, string address, string cMND, string phoneNumer, string email)
        {
            this.idCustomer = idCustomer;
            this.name = name;
            this.address = address;
            this.cMND = cMND;
            this.phoneNumer = phoneNumer;
            this.email = email;
        }

        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string PhoneNumer { get => phoneNumer; set => phoneNumer = value; }
        public string Email { get => email; set => email = value; }
    }
}
