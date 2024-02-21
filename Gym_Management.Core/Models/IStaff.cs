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
        public IEnumerable<Staff> GetAllStaff();
        public void DataPostStaff(Staff value);
        public void DataPutStaff(int index, Staff value);

    }
}
