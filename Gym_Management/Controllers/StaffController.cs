using AutoMapper;
using Gym_Management.Core.PostModel;
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
        public async Task<ActionResult<Staff>> Get()
        {
            var list = await _StaffService.GetStaffAsync();
            var newList = _mapper.Map<IEnumerable<StaffDto>>(list);
            return Ok(newList);
        }

        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var staff = await _StaffService.GetStaffByIDAsync(id);
            var newStaff = _mapper.Map<StaffDto>(staff);
            return Ok(newStaff);
        }

        // GET api/<StaffController>/5
        [HttpGet("Position/{position}")]
        public async Task<ActionResult<Staff>> Get(string position)
        {
            var List = await _StaffService.GetStaffByPositionAsync(position);
            var newList = _mapper.Map<IEnumerable<StaffDto>>(List);
            return Ok(newList);
        }

        // POST api/<StaffController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] StaffPostAndPutModel value)
        {
            var workerToPost = new Staff { Personal_Id = value.Personal_Id, Address = value.Address, Birth_Date = value.Birth_Date, Email = value.Email, Name = value.Name, Phone = value.Phone, Position = value.Position, Status = value.Status };
            var newWorker = await _StaffService.PostStaffAsync(workerToPost);
            return Ok(newWorker);
        }

        // PUT api/<StaffController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] StaffPostAndPutModel value)
        {
            var workerToUpdate = new Staff { Personal_Id = value.Personal_Id, Address = value.Address, Birth_Date = value.Birth_Date, Email = value.Email, Name = value.Name, Phone = value.Phone, Position = value.Position, Status = value.Status };
            var updated = await _StaffService.PutStaffAsync(id, workerToUpdate);
            var shorted = _mapper.Map<StaffDto>(updated);
            return Ok(shorted);
        }
    }
}
