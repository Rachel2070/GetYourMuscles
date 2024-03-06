using AutoMapper;
using Gym_Management.Core.DTOs;
using Gym_Management.Core.PostModel;
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
        public async Task<ActionResult<Subscriber>> Get()
        {
            var list = await _subscriberService.GetSubscribersAsync();
            var newList = _mapper.Map<IEnumerable<SubscriberDto>>(list);    
            return Ok(newList);
;
        }

        // GET api/<SubsciberControlller>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var sub = await _subscriberService.GetSubscribersByIdAsync(id);
            var newSub = _mapper.Map<SubscriberDto>(sub);
            return Ok(newSub);
        }

        // POST api/<SubsciberControlller>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SubsciberPostAndPutModel value)
        {
            var SubToPost = new Subscriber { Birth_Date=value.Birth_Date, Email=value.Email, Name=value.Name, Personal_Id=value.Personal_Id, Phone=value.Phone, StaffId=value.StaffId };
            var newSub = await _subscriberService.PostSubscriberAsync(SubToPost);
            return Ok(newSub);
        }

        // PUT api/<SubsciberControlller>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] SubsciberPostAndPutModel value)
        {
            var SubToUpdate = new Subscriber { Birth_Date = value.Birth_Date, Email = value.Email, Name = value.Name, Personal_Id = value.Personal_Id, Phone = value.Phone, StaffId = value.StaffId };
            var update = await _subscriberService.PutSubscriberAsync(id, SubToUpdate);
            return Ok(update);  
        }
    }
}
