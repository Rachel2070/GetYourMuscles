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
        public Task<IEnumerable<Subscriber>> GetSubscribersAsync();
        public Task<Subscriber> GetSubscribersByIdAsync(int id);
        public Task<Subscriber> PostSubscriberAsync(Subscriber value);
        public Task<Subscriber> PutSubscriberAsync(int id, Subscriber value);
    }
}
