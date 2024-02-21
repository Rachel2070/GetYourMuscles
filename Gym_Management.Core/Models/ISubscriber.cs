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
        public IEnumerable<Subscriber> GetAllSubscribers();
        public void DataPostSubscriber(Subscriber value);
        public void DataPutSubscriber(int id, Subscriber value);

    }
}
