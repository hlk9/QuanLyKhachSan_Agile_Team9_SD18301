using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Modal
{
    internal class Room
    {
        private string roomID;
        private string roomClass;
        private string roomName;
        private bool status;
        private double cost;

        public Room()
        {
            
        }

        public Room(string roomID, string roomClass, string roomName, bool status, double cost)
        {
            this.roomID = roomID;
            this.roomClass = roomClass;
            this.roomName = roomName;
            this.status = status;
            this.cost = cost;
        }

        public string RoomID { get => roomID; set => roomID = value; }
        public string RoomClass { get => roomClass; set => roomClass = value; }
        public string RoomName { get => roomName; set => roomName = value; }
        public bool Status { get => status; set => status = value; }
        public double Cost { get => cost; set => cost = value; }
    }
}
