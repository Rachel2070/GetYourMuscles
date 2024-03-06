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
        public Task<IEnumerable<Equipment>> GetEquipmentAsync();
        public Task<Equipment> GetByIdAsync(int id);
        public Task<Equipment> PostEquipmentAsync(Equipment value);
        public Task<Equipment> PutEquipmentAsync(int id, Equipment value);
        public Task<Equipment> DeleteEquipmentAsync(int id);

    }
}
