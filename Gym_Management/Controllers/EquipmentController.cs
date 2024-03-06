//using GYM_Managing.Classes;
///using GYM_Managing.Datas;
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
    public class EquipmentController : ControllerBase
    {
        private readonly IEquipmentService _equipmentService;

        public readonly IMapper _mapper;
        public EquipmentController(IEquipmentService context, IMapper mapper)
        {
            _equipmentService = context;
            _mapper = mapper;   
        }

        // GET: api/<EquipmentController>
        [HttpGet]
        public async Task<ActionResult<Equipment>> Get()
        {
            var list = await _equipmentService.GetEquipmentAsync();
            var newList = _mapper.Map<IEnumerable<EquipmentDto>>(list); 
            return Ok(newList);
        }

        // GET api/<EquipmentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var eq = await _equipmentService.GetByIdAsync(id);
            var newEq = _mapper.Map<EquipmentDto>(eq);
            return Ok(newEq);
        }

        // POST api/<EquipmentController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EquipmentPostAndPutModel value)
        {
            var eqToPost = new Equipment { Name = value.Name, Category = value.Category, Expiry_Date = value.Expiry_Date, Last_Check = value.Last_Check, Test_Frequencies = value.Test_Frequencies};
            var newEq =await _equipmentService.PostEquipmentAsync(eqToPost);
            return Ok(newEq);
        }

        // PUT api/<EquipmentController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] EquipmentPostAndPutModel value)
        {
            var eqToPut = new Equipment { Name = value.Name, Category = value.Category, Expiry_Date = value.Expiry_Date, Last_Check = value.Last_Check, Test_Frequencies = value.Test_Frequencies };
            var updated = await _equipmentService.PutEquipmentAsync(id, eqToPut);
            return Ok(updated);
        }

        // DELETE api/<EquipmentController>/5
        [HttpDelete("{id}")]
        public async Task<Equipment> Delete(int id)
        { 
          return await _equipmentService.DeleteEquipmentAsync(id);
        }
    }
}
