using GYM_Management.Core.Models;
using GYM_Management.Core.ServiceModels;
using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Servies.ServiceRpository
{
    public class StaffService: IStaffService
    {
        private readonly IStaff _staffRepository;

        public StaffService(IStaff equipmentRepository)
        {
            _staffRepository = equipmentRepository;
        }

        public Task<IEnumerable<Staff>> GetStaffAsync()
        {
            return _staffRepository.GetAllStaffAsync();
        }

        public async Task<Staff> GetStaffByIDAsync(int id)
        {
            var list =await _staffRepository.GetAllStaffAsync();
            Staff foundStaff =  list.First(t => t.Worker_Number == id);
            if (foundStaff ==null)
                return null;
            return foundStaff;
        }

        public async Task<IEnumerable<Staff>> GetStaffByPositionAsync(string position)
        {
            var list = await _staffRepository.GetAllStaffAsync();
            var findPosition = list.Where(t => t.Position.ToLower() == position.ToLower());
            if (findPosition == null)
                return null;
            return findPosition;
        }

        public async Task<Staff> PostStaffAsync(Staff value)
        {
           return  await _staffRepository.DataPostStaffAsync(value);
        }

        public async Task<Staff> PutStaffAsync(int id, Staff value)
        {
            return await _staffRepository.DataPutStaffAsync(id, value);
        }
    }
}
