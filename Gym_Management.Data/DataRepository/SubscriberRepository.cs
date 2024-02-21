using GYM_Management.Core.Models;
using GYM_Management.Data.DataContext;
using GYM_Managing.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_Management.Data.DataRepository
{
    public class SubscriberRepository: ISubscriber
    {
        private readonly GymData _context;

        public SubscriberRepository(GymData subscriberContext)
        {
            _context = subscriberContext;   
        }

        public IEnumerable<Subscriber> GetAllSubscribers()
        {
            return _context.GymSubscribers.Include(s=>s.Staff);
        }
        public void DataPostSubscriber(Subscriber value)
        {
            _context.GymSubscribers.Add(value);
            _context.SaveChanges();
        }
        public void DataPutSubscriber(int index, Subscriber value)
        {
            _context.GymSubscribers.ToList()[index] = value;
            _context.SaveChanges();
        }


    }
}
