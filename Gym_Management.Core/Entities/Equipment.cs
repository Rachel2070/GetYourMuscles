namespace GYM_Managing.Classes
{
    public class Equipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Last_Check { get; set; }
        public int Test_Frequencies { get; set; }
        public DateTime Expiry_Date { get; set; }
        public List<Staff> Staffs { get; set; } 
    }
}
