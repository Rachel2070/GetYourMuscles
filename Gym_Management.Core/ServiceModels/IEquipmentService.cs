using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Core.ServiceModels
{
    public interface IEquipmentService
    {
        public IEnumerable<Equipment> GetEquipment();
        Equipment GetByID(int id);
        public void PostEquipment(Equipment value);
        public void PutEquipment(int id, Equipment value);
        public void DeleteEquipment(int id);

    }
}
