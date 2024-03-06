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
    public class EquipmentService : IEquipmentService
    {
        private readonly IEquipment _equipmentRepository;


        public EquipmentService(IEquipment equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        public async Task<IEnumerable<Equipment>> GetEquipmentAsync()
        {
            return await _equipmentRepository.GetAllEquipmentAsync();
        }

        public async Task<Equipment> GetByIdAsync(int id)
        {
            var list = await _equipmentRepository.GetAllEquipmentAsync();
            Equipment foundsEq = list.First(s => s.Id == id);
            if (foundsEq == null)
                return null;
            return foundsEq;
        }

        public async Task<Equipment> PostEquipmentAsync(Equipment value)
        {
           return await _equipmentRepository.DataPostEquipmentAsync(value);
        }

        public async Task<Equipment> PutEquipmentAsync(int id, Equipment value)
        {
            return await _equipmentRepository.DataPutEquipmentAsync( id, value);
        }

        public async Task<Equipment> DeleteEquipmentAsync(int id)
        {
            var list = await _equipmentRepository.GetAllEquipmentAsync();
            Equipment foundEq = list.First((Equipment e) => e.Id == id);
            if (foundEq != null)
                return await _equipmentRepository.DataDeleteEquipmentAsync(foundEq);
            return null;
        }
    }
}
