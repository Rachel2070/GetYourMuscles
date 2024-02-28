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
        public IEnumerable<Subscriber> GetSubscribers()
        {
            return _subscriberRepository.GetAllSubscribers();
        }

        public Subscriber GetSubscribers(int id)
        {
            int index = _subscriberRepository.GetAllSubscribers().ToList().FindIndex(s => s.Subscription_Number == id);
            if (index == -1)
                return null;
            return _subscriberRepository.GetAllSubscribers().ToList()[index];
        }

        public Subscriber PostSubscriber(Subscriber value)
        {
            _subscriberRepository.DataPostSubscriber(value);
            IdCount++;
            return value;
        }

        public Subscriber PutSubscriber(int id, Subscriber value)
        {
            int index = _subscriberRepository.GetAllSubscribers().ToList().FindIndex((Subscriber s) => s.Subscription_Number == id);
            if (index != -1)
            {
                Subscriber foundsub = _subscriberRepository.GetAllSubscribers().ToList()[index];

                foundsub.Personal_Id = foundsub.Personal_Id;
                foundsub.Subscription_Number = foundsub.Subscription_Number;
                foundsub.Email = value.Email;
                foundsub.Name = value.Name;
                foundsub.Status = value.Status;
                foundsub.Birth_Date = value.Birth_Date;
                foundsub.End_Subscription_Date = value.End_Subscription_Date;
                foundsub.Start_Subscription_Date = value.Start_Subscription_Date;
                _subscriberRepository.DataPutSubscriber(index, value);
                return foundsub;
            }
            return null;
        }
    }
}
