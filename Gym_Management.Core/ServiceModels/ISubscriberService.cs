using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Core.ServiceModels
{
    public interface ISubscriberService
    {
        public IEnumerable<Subscriber> GetSubscribers();
        public Subscriber GetSubscribers(int id);
        public void PostSubscriber(Subscriber value);
        public void PutSubscriber(int id, Subscriber value);
    }
}
