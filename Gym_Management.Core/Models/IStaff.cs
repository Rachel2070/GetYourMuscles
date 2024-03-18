using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Core.Models
{
    public interface IStaff
    {
        public Task<IEnumerable<Staff>> GetAllStaffAsync();
        public Task<Staff> DataPostStaffAsync(Staff value);
        public Task<Staff> DataPostEquiepmentToStaffAsync(int staffId, int eqId);
        public Task<Staff> DataPutStaffAsync(int id, Staff value);

    }
}
