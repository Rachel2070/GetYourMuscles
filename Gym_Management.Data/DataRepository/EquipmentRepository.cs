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
    public class EquipmentRepository: IEquipment
    {
        private readonly GymData _context;

        public EquipmentRepository(GymData equipmentContext)
        {
            _context = equipmentContext; 
        }

        public IEnumerable<Equipment> GetAllEquipment()
        {
            return _context.GymEquipment.Include(e=>e.Staffs);
        }
        public void DataPostEquipment(Equipment value)
        {
            _context.GymEquipment.Add(value);
            _context.SaveChanges();
        }

        public void DataPutEquipment(int index, Equipment value)
        {
            _context.GymEquipment.ToList()[index] = value;
            _context.SaveChanges();
        }

        public void DataDeleteEquipment(int index)
        {
            _context.Remove(_context.GymEquipment.ToList()[index]);
            _context.SaveChanges();
        }


    }
}
