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
        public Task<IEnumerable<Equipment>> GetAllEquipmentAsync();
        public Task<Equipment> DataPostEquipmentAsync(Equipment value);
        public Task<Equipment> DataPutEquipmentAsync(int id, Equipment value);
        public Task<Equipment> DataDeleteEquipmentAsync(Equipment e);

    }
}
