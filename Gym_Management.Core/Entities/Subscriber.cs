using System.ComponentModel.DataAnnotations;

namespace GYM_Managing.Classes
{
    public class Subscriber
    {
        [Key]
        public int Subscription_Number { get; set; }
        public int Personal_Id { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public DateTime Start_Subscription_Date { get; set; }
        public DateTime End_Subscription_Date { get; set; }
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
