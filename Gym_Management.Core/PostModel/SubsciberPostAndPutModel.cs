using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Core.PostModel
{
    public class SubsciberPostAndPutModel
    {
        public int Personal_Id { get; set; }
        public DateTime Birth_Date { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int StaffId { get; set; }
    }
}
