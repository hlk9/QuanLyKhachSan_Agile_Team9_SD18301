using QuanLyKhachSan.Modal;
using System.Text.Json;
namespace QuanLyKhachSan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            //GenerateUser();

        }
        public void GenerateRoom()
        {
            List<Room> lstRoom = new List<Room>();
            lstRoom.Add(new Room("R001", "Standard Room", "ST101", true, 800000));
            lstRoom.Add(new Room("R002", "Standard Room", "ST102", false, 1200000));
            lstRoom.Add(new Room("R003", "Standard Room", "ST103", true, 900000));
            lstRoom.Add(new Room("R004", "Standard Room", "ST104", true, 1000000));
            lstRoom.Add(new Room("R005", "Standard Room", "ST105", true, 800000));
            lstRoom.Add(new Room("R006", "Standard Room", "ST202", false, 800000));
            lstRoom.Add(new Room("R007", "Deluxe Room", "DL303", false, 2500000));
            lstRoom.Add(new Room("R008", "Deluxe Room", "DL301", true, 3000000));
            lstRoom.Add(new Room("R009", "Deluxe Room", "DL302", true, 8000000));
            lstRoom.Add(new Room("R010", "Deluxe Room", "DL305", true, 4000000));
            lstRoom.Add(new Room("R011", "Deluxe Room", "DL401", true, 8000000));
            lstRoom.Add(new Room("R012", "VIP Room", "VI402", true, 20000000));
            lstRoom.Add(new Room("R001", "VIP Room", "VI404", true, 20000000));
            string raw = JsonSerializer.Serialize(lstRoom);
            string fileData = "RoomData.json";
            File.WriteAllText(fileData, raw);
        }
        public void GenerateUser()
        {
            List<User> lstUser = new List<User>();
            string[] staff = { "Staff", "View Room" };
            string[] manager = { "Manager", "Edit Room" };
            lstUser.Add(new User("staff", "123", staff));
            lstUser.Add(new User("manager", "123", manager));
            string raw = JsonSerializer.Serialize(lstUser);
            string fileData = "UserData.json";
            File.WriteAllText(fileData, raw);
        }
        
    }
}