//using GYM_Managing.Classes;
///using GYM_Managing.Datas;
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
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;

        public readonly IMapper _mapper;
        public EquipmentController(IEquipmentService context, IMapper mapper)
        {
            _equipmentService = context;
            _mapper = mapper;   
        }
        //public static int IdCount = 4;
        // GET: api/<EquipmentController>
        [HttpGet]
        public ActionResult<Equipment> Get()
        {
            var list = _equipmentService.GetEquipment();
            var newList = _mapper.Map<IEnumerable<EquipmentDto>>(list); 
            return Ok(newList);
        }

        // GET api/<EquipmentController>/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            var eq = _equipmentService.GetByID(id);
            var newEq = _mapper.Map<EquipmentDto>(eq);
            return Ok(newEq);
        }

        // POST api/<EquipmentController>
        [HttpPost]
        public ActionResult Post([FromBody] Equipment value)
        {
            var newEq = _equipmentService.PostEquipment(value);
            return Ok(newEq);
        }

        // PUT api/<EquipmentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Equipment value)
        {
            var updated = _equipmentService.PutEquipment(id, value);
            return Ok(updated);
        }

        // DELETE api/<EquipmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        { 
            _equipmentService.DeleteEquipment(id);
        }
    }
}
