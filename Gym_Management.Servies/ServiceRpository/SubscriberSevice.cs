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
    public class SubscriberSevice: ISubscriberService
    {
        private readonly ISubscriber _subscriberRepository;
        private static int IdCount = 4;


        public SubscriberSevice(ISubscriber equipmentRepository)
        {
            _subscriberRepository = equipmentRepository;
        }
        public async Task<IEnumerable<Subscriber>> GetSubscribersAsync()
        {
            return await _subscriberRepository.GetAllSubscribersAsync();
        }

        public async Task<Subscriber> GetSubscribersByIdAsync(int id)
        {
            var list = await _subscriberRepository.GetAllSubscribersAsync();
            Subscriber foundSub = list.First(s => s.StaffId == id);
            if (foundSub ==null)
                return null;
            return foundSub;
        }

        public async Task<Subscriber> PostSubscriberAsync(Subscriber value)
        {
           return await _subscriberRepository.DataPostSubscriberAsync(value);
        }

        public async Task<Subscriber> PutSubscriberAsync(int id, Subscriber value)
        {
            return await _subscriberRepository.DataPutSubscriberAsync(id, value);
        }
    }
}
