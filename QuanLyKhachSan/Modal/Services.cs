using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Modal
{
    internal class Services
    {
        private string id;
        private string name;
        private string cost;

        public Services()
        {
                
        }

        public Services(string id, string name, string cost)
        {
            this.id = id;
            this.name = name;
            this.cost = cost;
        }

        public string Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Cost { get => cost; set => cost = value; }
    }
}
