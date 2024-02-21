using GYM_Management.Core.Models;
using GYM_Management.Data.DataContext;
using GYM_Managing.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Data.DataRepository
{
    public class StaffRepository: IStaff
    {
        private readonly GymData _context;

        public StaffRepository(GymData staffContext)
        {
            _context = staffContext; 
        }

        public IEnumerable<Staff> GetAllStaff()
        {
            return _context.GymStaff.Include(s=>s.Subscribers).Include(e=>e.EquipmentInCategory);
        }

        public void DataPostStaff(Staff value)
        {
            _context.GymStaff.Add(value);
            _context.SaveChanges();
        }
        public void DataPutStaff(int index, Staff value)
        {
            _context.GymStaff.ToList()[index] = value;
            _context.SaveChanges();
        }


    }
}
