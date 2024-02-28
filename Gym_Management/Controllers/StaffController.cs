using AutoMapper;
using Gym_Management.Core.TDOs;
using GYM_Management.Core.ServiceModels;
using GYM_Managing.Classes;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Gym.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        private readonly IStaffService _StaffService;
        public readonly IMapper _mapper;

        public StaffController(IStaffService context, IMapper mapper)
        {
            _StaffService = context;
            _mapper = mapper;
        }

        // GET: api/<StaffController>
        [HttpGet]
        public ActionResult<Staff> Get()
        {
            var list =  _StaffService.GetStaff();
            var newList = _mapper.Map<IEnumerable<StaffDto>>(list);
            return Ok(newList);
        }

        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var staff = _StaffService.GetStaffByID(id);
            var newStaff = _mapper.Map<StaffDto>(staff);
            return Ok(newStaff);
        }

        // GET api/<StaffController>/5
        [HttpGet("Position/{position}")]
        public ActionResult<Staff> Get(string position)
        {
            var List =  _StaffService.GetStaffByPosition(position);
            var newList = _mapper.Map<IEnumerable<StaffDto>>(List);
            return Ok(newList);
        }

        // POST api/<StaffController>
        [HttpPost]
        public void Post([FromBody] Staff value)
        {
             _StaffService.PostStaff(value);
        }

        // PUT api/<StaffController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Staff value)
        {
            _StaffService.PutStaff(id, value);   
        }
    }
}
