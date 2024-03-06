using GYM_Managing.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Core.Models
{
    public interface ISubscriber
    {
        public Task<IEnumerable<Subscriber>> GetAllSubscribersAsync();
        public Task<Subscriber> DataPostSubscriberAsync(Subscriber value);
        public Task<Subscriber> DataPutSubscriberAsync(int id, Subscriber value);

    }
}
