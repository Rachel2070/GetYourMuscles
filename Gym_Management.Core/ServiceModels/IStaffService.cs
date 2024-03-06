using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Core.ServiceModels
{
    public interface IStaffService
    {
        public Task<IEnumerable<Staff>> GetStaffAsync();
        public Task<Staff> GetStaffByIDAsync(int id);
        public Task<IEnumerable<Staff>> GetStaffByPositionAsync(string position);
        public Task<Staff> PostStaffAsync(Staff value);
        public Task<Staff> PutStaffAsync(int id, Staff value);
    }
}
