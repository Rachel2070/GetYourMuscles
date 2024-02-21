using GYM_Managing.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Data.DataContext
{
    public class GymData : DbContext
    {
        public DbSet<Equipment> GymEquipment { get; set; }
        public DbSet<Staff> GymStaff { get; set; }
        public DbSet<Subscriber> GymSubscribers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Gym_DB");
        }

        //public EquipmentData()
        //{
        //    GymEquipment = new List<Equipment> {
        //        new Equipment{Id = 1, Name="eliptical", Category="airoby", Expiry_Date=(new DateTime(2025,02,02)), Last_Check=(new DateTime(2020,02,02)), Test_Frequencies=1},
        //             new Equipment{Id = 2, Name="wights", Category="strength", Expiry_Date=(new DateTime(2030,02,02)), Last_Check=(new DateTime(2021,02,02)), Test_Frequencies=5},
        //                    new Equipment{Id = 3, Name="bar", Category="strength", Expiry_Date=(new DateTime(2030,02,02)), Last_Check=(new DateTime(2020,02,02)), Test_Frequencies=5}
        //    };
        //}

    }
}
