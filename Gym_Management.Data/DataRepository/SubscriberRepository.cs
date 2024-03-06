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

        public async Task<IEnumerable<Subscriber>> GetAllSubscribersAsync()
        {
            return await _context.GymSubscribers.Include(s=>s.Staff).ToListAsync();
        }

        public async Task<Subscriber> DataPostSubscriberAsync(Subscriber value)
        {
            _context.GymSubscribers.Add(value);
            await _context.SaveChangesAsync();
            return value;   
        }
        public async Task<Subscriber> DataPutSubscriberAsync(int id, Subscriber value)
        {
            var list = await _context.GymSubscribers.ToListAsync();
            var foundSub =  list.First((s) => s.Subscription_Number == id);
            if (foundSub != null)
            {
                foundSub.Personal_Id = foundSub.Personal_Id;
                foundSub.Subscription_Number = foundSub.Subscription_Number;
                foundSub.Email = value.Email;
                foundSub.Name = value.Name;
                foundSub.Status = value.Status;
                foundSub.Birth_Date = value.Birth_Date;
                foundSub.End_Subscription_Date = value.End_Subscription_Date;
                foundSub.Start_Subscription_Date = value.Start_Subscription_Date;

                await _context.SaveChangesAsync();
                
                return foundSub;
            }
            return null;
        }
    }
}
