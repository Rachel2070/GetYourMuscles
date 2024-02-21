using GYM_Management.Core.ServiceModels;
using GYM_Managing.Classes;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GYM_Managing.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubsciberController : ControllerBase
    {
        private readonly ISubscriberService _subscriberService;
        public SubsciberController(ISubscriberService context)
        {
            _subscriberService = context;
        }
        // GET: api/<SubsciberControlller>
        [HttpGet]
        public IEnumerable<Subscriber> Get()
        {
            return _subscriberService.GetSubscribers();
;
        }

        // GET api/<SubsciberControlller>/5
        [HttpGet("{id}")]
        public Subscriber Get(int id)
        {
            //Subscriber foundsub = _subscriberService.GetSubscribers().Find(s => s.Subscription_Number == id);
            //if (foundsub == null)
            //    return null;
            //return foundsub;
            return _subscriberService.GetSubscribers(id);
        }

        // POST api/<SubsciberControlller>
        [HttpPost]
        public void Post([FromBody] Subscriber value)
        {
            //Subscriber s = new() { Personal_Id = value.Personal_Id, Subscription_Number = IdCount, Name = value.Name, Email = value.Email, Phone = value.Phone, Status = value.Status, Birth_Date = value.Birth_Date, Start_Subscription_Date = value.Start_Subscription_Date, End_Subscription_Date = value.End_Subscription_Date };
            //_subscriberService.GetSubscribers().Add(s);
            //IdCount++;
            //return s;
             _subscriberService.PostSubscriber(value);
        }

        // PUT api/<SubsciberControlller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Subscriber value)
        {
            //Subscriber foundsub = _subscriberService.GetSubscribers().Find(s => s.Subscription_Number == id);
            //if (foundsub != null)
            //{
            //    foundsub.Personal_Id = foundsub.Personal_Id;
            //    foundsub.Subscription_Number = foundsub.Subscription_Number;
            //    foundsub.Email = value.Email;
            //    foundsub.Name = value.Name;
            //    foundsub.Status = value.Status;
            //    foundsub.Birth_Date = value.Birth_Date;
            //    foundsub.End_Subscription_Date = value.End_Subscription_Date;
            //    foundsub.Start_Subscription_Date = value.Start_Subscription_Date;

            //}
            //return foundsub;
            _subscriberService.PutSubscriber(id, value);
        }

        // DELETE api/<SubsciberControlller>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
