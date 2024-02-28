using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Core.DTOs
{
    public class EquipmentDto
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public DateTime Last_Check { get; set; }
        public int Test_Frequencies { get; set; }
        public DateTime Expiry_Date { get; set; }
    }
}
