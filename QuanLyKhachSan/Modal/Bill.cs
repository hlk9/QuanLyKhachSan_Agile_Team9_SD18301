using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyKhachSan.Modal
{
    internal class Bill
    {
        private string idBill;
        private string idCustomer;
        private string roomID;
        private string[] serviceID;
        private DateTime bookingDate;
        private DateTime checkOutDate;
        private double totalCost;
        private bool isPaid;

        public Bill(string idBill, string idCustomer, string roomID, string[] serviceID, DateTime bookingDate, DateTime checkOutDate, double totalCost, bool isPaid)
        {
            this.idBill = idBill;
            this.idCustomer = idCustomer;
            this.roomID = roomID;
            this.serviceID = serviceID;
            this.bookingDate = bookingDate;
            this.checkOutDate = checkOutDate;
            this.totalCost = totalCost;
            this.isPaid = isPaid;
        }

        public string IdBill { get => idBill; set => idBill = value; }
        public string IdCustomer { get => idCustomer; set => idCustomer = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public string[] ServiceID { get => serviceID; set => serviceID = value; }
        public DateTime BookingDate { get => bookingDate; set => bookingDate = value; }
        public DateTime CheckOutDate { get => checkOutDate; set => checkOutDate = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }
        public bool IsPaid { get => isPaid; set => isPaid = value; }
        
        public Bill()
        {
            
        }
        public double TotalPay()
        {
            return this.TotalCost + (this.TotalCost * 10);
        }
    }
}
