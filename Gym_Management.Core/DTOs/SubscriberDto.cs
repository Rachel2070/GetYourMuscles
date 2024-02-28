using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Core.DTOs
{
    public class SubscriberDto
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
    }
}
