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
        public IEnumerable<Staff> GetStaff();
        public Staff GetStaffByID(int id);
        public List<Staff> GetStaffByPosition(string position);
        public Staff PostStaff(Staff value);
        public Staff PutStaff(int id, Staff value);
    }
}
