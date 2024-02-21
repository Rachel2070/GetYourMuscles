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
    public class EquipmentService: IEquipmentService
    {
        private readonly IEquipment _equipmentRepository;
        public static int IdCount = 4;


        public EquipmentService(IEquipment equipmentRepository)
        {
            _equipmentRepository = equipmentRepository;
        }
        public IEnumerable<Equipment> GetEquipment()
        {
            return _equipmentRepository.GetAllEquipment();
        }

        public Equipment GetByID(int id)
        {
            Equipment foundsEq = _equipmentRepository.GetAllEquipment().ToList().Find(s => s.Id == id);
            if (foundsEq == null)
                return null;
            return foundsEq;
        }

        public void PostEquipment(Equipment value)
        {
            _equipmentRepository.DataPostEquipment(value);
            IdCount++;
        }

        public void PutEquipment(int id, Equipment value)
        {
            int index = _equipmentRepository.GetAllEquipment().ToList().FindIndex((Equipment e) => e.Id == id);
            if (index != -1) {
                Equipment foundEq = _equipmentRepository.GetAllEquipment().ToList()[index];

                foundEq.Id = foundEq.Id;
                foundEq.Name = foundEq.Name;
                foundEq.Category = value.Category;
                foundEq.Last_Check = value.Last_Check;
                foundEq.Test_Frequencies = value.Test_Frequencies;
                foundEq.Expiry_Date = value.Expiry_Date;

                _equipmentRepository.DataPutEquipment(index, foundEq);
            }
        }

        public void DeleteEquipment(int id)
        {
            int index = _equipmentRepository.GetAllEquipment().ToList().FindIndex(e => e.Id == id);
            if (index != -1)
                _equipmentRepository.DataDeleteEquipment(index);
        }
    }
}
