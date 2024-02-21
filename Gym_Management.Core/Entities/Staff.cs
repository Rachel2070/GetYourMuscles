using GYM_Management.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace GYM_Managing.Classes
{
    public class Staff
    {
        [Key]
        public int Worker_Number { get; set; }
        public int Personal_Id { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Status { get; set; }
        public string Address { get; set; }
        public string Position { get; set; }
        public List<Subscriber> Subscribers { get; set; }
        public List<Equipment> EquipmentInCategory { get; set; }  

    }
}
