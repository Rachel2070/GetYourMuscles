using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Core.PostModel
{
    public class EquipmentPostAndPutModel
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Last_Check { get; set; }
        public int Test_Frequencies { get; set; }
        public DateTime Expiry_Date { get; set; }
    }
}
