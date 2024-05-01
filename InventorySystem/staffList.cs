namespace InventorySystem
{
    public class staffList
    {
        public string Staff_ID { get; set; }
        public string Staff_Name { get; set; }
        public string Staff_Username { get; set; }
        public string Staff_StaffRole { get; set; }
        public string Staff_StaffStatus { get; set; }

        public staffList()
        {
            Staff_ID = "";
            Staff_Name = "";
            Staff_Username = "";
            Staff_StaffRole = "";
            Staff_StaffStatus = "";
        }
    }
}
