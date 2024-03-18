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

        public async Task<IEnumerable<Staff>> GetAllStaffAsync()
        {
            return await _context.GymStaff.Include(s=>s.Subscribers).Include(e=>e.EquipmentInCategory).ToArrayAsync();
        }

        public async Task<Staff> DataPostStaffAsync(Staff value)
        {
            _context.GymStaff.Add(value);
           await _context.SaveChangesAsync();
            return value;
        }

        public async Task<Staff> DataPostEquiepmentToStaffAsync(int staffId, int eqId)
        {
            // Find the staff member by ID
            Staff postToStaff = await _context.GymStaff
            .Include(s => s.EquipmentInCategory) // Include equipmentInCategory navigation property
              .FirstOrDefaultAsync(s => s.Worker_Number == staffId);

            // Find the equipment by ID
            Equipment equipmentToStaff = await _context.GymEquipment.FirstOrDefaultAsync(e => e.Id == eqId);

            // Ensure the staff member and equipment exist
            if (postToStaff != null && equipmentToStaff != null)
            {
                // Initialize the equipmentInCategory collection if it's null
                if (postToStaff.EquipmentInCategory == null)
                {
                    postToStaff.EquipmentInCategory = new List<Equipment>();
                }

                // Always add the equipment to the end of the list
                postToStaff.EquipmentInCategory.Add(equipmentToStaff);

                // Save changes to the database
                await _context.SaveChangesAsync();
            }

            return postToStaff;
        }

        public async Task<Staff> DataPutStaffAsync(int id, Staff value)
        {
            var list = await _context.GymStaff.ToListAsync();
             Staff foundStaff = list.Find(( s) => s.Worker_Number == id);
            if (foundStaff != null)
            {
                foundStaff.Personal_Id = foundStaff.Personal_Id;
                foundStaff.Worker_Number = foundStaff.Worker_Number;
                foundStaff.Email = value.Email;
                foundStaff.Name = value.Name;
                foundStaff.Status = value.Status;
                foundStaff.Birth_Date = value.Birth_Date;
                foundStaff.Address = value.Address;
                foundStaff.Status = value.Status;
                foundStaff.Position = value.Position;

                await _context.SaveChangesAsync();  
               return foundStaff;   
            }
            return null;
        }

    }
}
