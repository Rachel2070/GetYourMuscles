//using GYM_Managing.Classes;
///using GYM_Managing.Datas;
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
        public EquipmentController(IEquipmentService context)
        {
            _equipmentService = context;
        }
        public static int IdCount = 4;
        // GET: api/<EquipmentController>
        [HttpGet]
        public IEnumerable<Equipment> Get()
        {
            return _equipmentService.GetEquipment();
        }

        // GET api/<EquipmentController>/5
        [HttpGet("{id}")]
        public Equipment Get(int id)
        {
            //Equipment foundsEq = _equipmentService.GetEquipment().Find(s => s.Id == id);
            //if (foundsEq == null)
            //    return null;
            //return foundsEq;
            return _equipmentService.GetByID(id);
        }

        // POST api/<EquipmentController>
        [HttpPost]
        public void Post([FromBody] Equipment value)
        {
            //Equipment e = new() { Id = IdCount, Name = value.Name, Category = value.Category, Last_Check = value.Last_Check, Test_Frequencies = value.Test_Frequencies, Expiry_Date = value.Expiry_Date };
            //_equipmentService.GetEquipment().Add(e);
            //    IdCount++;
            //    return e;
            _equipmentService.PostEquipment(value);  
        }

        // PUT api/<EquipmentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Equipment value)
        {
            //Equipment foundEq = _equipmentService.GetEquipment().Find(e => e.Id == id);
            //if (foundEq != null)
            //{
            //    foundEq.Id = foundEq.Id;
            //    foundEq.Name = foundEq.Name;
            //    foundEq.Category = value.Category;
            //    foundEq.Last_Check = value.Last_Check;
            //    foundEq.Test_Frequencies = value.Test_Frequencies;
            //    foundEq.Expiry_Date = value.Expiry_Date;
            //}
            //return foundEq;
            _equipmentService.PutEquipment(id, value);
        }

        // DELETE api/<EquipmentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            //Equipment foundEq = _equipmentService.GetEquipment().Find(e => e.Id == id);
            //if(foundEq != null)
            //    _equipmentService.GetEquipment().Remove(foundEq);  
            _equipmentService.DeleteEquipment(id);
        }
    }
}
