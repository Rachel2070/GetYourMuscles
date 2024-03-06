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
    public class EquipmentRepository : IEquipment
    {
        private readonly GymData _context;

        public EquipmentRepository(GymData equipmentContext)
        {
            _context = equipmentContext;
        }

        public async Task<IEnumerable<Equipment>> GetAllEquipmentAsync()
        {
            return await _context.GymEquipment.Include(e => e.Staffs).ToListAsync();
        }
        public async Task<Equipment> DataPostEquipmentAsync(Equipment value)
        {
            _context.GymEquipment.Add(value);
            await _context.SaveChangesAsync();
            return value;
        }

        public async Task<Equipment> DataPutEquipmentAsync(int id, Equipment value)
        {
            var list = await _context.GymEquipment.ToListAsync();
            Equipment foundEq = list.First((e) => e.Id == id);
            if (foundEq != null)
            {
                foundEq.Id = foundEq.Id;
                foundEq.Name = value.Name;
                foundEq.Category = value.Category;
                foundEq.Last_Check = value.Last_Check;
                foundEq.Test_Frequencies = value.Test_Frequencies;
                foundEq.Expiry_Date = value.Expiry_Date;

                await _context.SaveChangesAsync();

                return foundEq;
            }
            return null;
           
        }

        public async Task<Equipment> DataDeleteEquipmentAsync(Equipment e)
        {
            var equipment = _context.GymEquipment.First(x => x == e);
            _context.Remove(equipment);
            await _context.SaveChangesAsync();
            return equipment;
        }
    }
}
