using AutoMapper;
using Gym_Management.Core.DTOs;
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
        public readonly IMapper _mapper;

        public SubsciberController(ISubscriberService context, IMapper mapper)
        {
            _subscriberService = context;
            _mapper = mapper;   
        }
        // GET: api/<SubsciberControlller>
        [HttpGet]
        public ActionResult<Subscriber> Get()
        {
            var list = _subscriberService.GetSubscribers();
            var newList = _mapper.Map<IEnumerable<SubscriberDto>>(list);    
            return Ok(newList);
;
        }

        // GET api/<SubsciberControlller>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var sub = _subscriberService.GetSubscribers(id);
            var newSub = _mapper.Map<SubscriberDto>(sub);
            return Ok(newSub);
        }

        // POST api/<SubsciberControlller>
        [HttpPost]
        public ActionResult Post([FromBody] Subscriber value)
        {
            var newSub = _subscriberService.PostSubscriber(value);
            return Ok(newSub);
        }

        // PUT api/<SubsciberControlller>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Subscriber value)
        {
           var update = _subscriberService.PutSubscriber(id, value);
            return Ok(update);  
        }
    }
}
