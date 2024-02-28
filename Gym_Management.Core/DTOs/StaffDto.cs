﻿using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Management.Core.TDOs
{
    public class StaffDto
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
        //public List<int> SubscriberId { get; set; }

    }
}
