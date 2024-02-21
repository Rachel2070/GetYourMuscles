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
    public class StaffService: IStaffService
    {
        private readonly IStaff _staffRepository;
        private static int IdCount = 3;


        public StaffService(IStaff equipmentRepository)
        {
            _staffRepository = equipmentRepository;
        }
        public IEnumerable<Staff> GetStaff()
        {
            return _staffRepository.GetAllStaff();
        }

        public Staff GetStaffByID(int id)
        {
            int index = _staffRepository.GetAllStaff().ToList().FindIndex(t => t.Worker_Number == id);
            if (index == -1)
                return null;
            return _staffRepository.GetAllStaff().ToList()[index];
        }

        public List<Staff> GetStaffByPosition(string position)
        {
            var foundpos = _staffRepository.GetAllStaff().Where(t => t.Position.ToLower() == position.ToLower()).ToList();
            if (foundpos == null)
                return null;
            return foundpos;
        }

        public void PostStaff(Staff value)
        {
            _staffRepository.DataPostStaff(value);
            IdCount++;
        }

        public void PutStaff(int id, Staff value)
        {
            int index = _staffRepository.GetAllStaff().ToList().FindIndex((Staff s) => s.Worker_Number == id);
            if(index != -1) { 
                Staff foundWorker = _staffRepository.GetAllStaff().ToList()[index];

                foundWorker.Personal_Id = foundWorker.Personal_Id;
                foundWorker.Worker_Number = foundWorker.Worker_Number;
                foundWorker.Email = value.Email;
                foundWorker.Name = value.Name;
                foundWorker.Status = value.Status;
                foundWorker.Birth_Date = value.Birth_Date;
                foundWorker.Address = value.Address;
                foundWorker.Status = value.Status;
                foundWorker.Position = value.Position;

                _staffRepository.DataPutStaff(index, foundWorker);  
            }
        }
    }
}
