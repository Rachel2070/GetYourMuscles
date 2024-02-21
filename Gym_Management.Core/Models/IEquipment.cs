using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Core.Models
{
    public interface IEquipment
    {
        public IEnumerable<Equipment> GetAllEquipment();
        public void DataPostEquipment(Equipment value);
        public void DataPutEquipment(int id, Equipment value);
        public void DataDeleteEquipment(int id);

    }
}
