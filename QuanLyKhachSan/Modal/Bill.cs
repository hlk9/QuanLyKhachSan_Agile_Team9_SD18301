using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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
            List<Services> lstService = new List<Services>();
            string rawSer = File.ReadAllText("ServiceData.json");
            lstService = JsonSerializer.Deserialize<List<Services>>(rawSer);
            double days = (checkOutDate - bookingDate).TotalDays;
            if (days <= 0) days = 1;

            double cost = totalCost * days;


            try
            {
               
                if (this.ServiceID.Length > 0)
                {
                    foreach (string id in this.ServiceID)
                    {
                        var ser = lstService.FirstOrDefault(x => x.Id == id);
                        if (ser != null)
                        {
                            cost += double.Parse(ser.Cost);
                        }
                    }
                }

                return cost + (cost * 0.1);
            }
            catch
            {
                return cost + (cost * 0.1);
            }

           
        }
    }
}
