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
        public StaffController(IStaffService context)
        {
            _StaffService = context;
        }

        // GET: api/<StaffController>
        [HttpGet]
        public IEnumerable<Staff> Get()
        {
            return _StaffService.GetStaff();
        }

        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public Staff Get(int id)
        {
            //Staff foundWorker = _StaffService.GetStaff().Find(t => t.Worker_Number == id);
            //if (foundWorker == null)
            //    return null;
            //return foundWorker;
            return _StaffService.GetStaffByID(id);
        }

        // GET api/<StaffController>/5
        [HttpGet("Position/{position}")]
        public List<Staff> Get(string position)
        {
            //var foundpos = _StaffService.GetStaff().Where(t => t.Position.ToLower() == position.ToLower()).ToList();
            //if (foundpos == null)
            //    return null;
            //return foundpos;
            return _StaffService.GetStaffByPosition(position);
        }

        // POST api/<StaffController>
        [HttpPost]
        public void Post([FromBody] Staff value)
        {
            //Staff s = new() { Worker_Number = IdCount, Name = value.Name, Birth_Date = value.Birth_Date, Personal_Id = value.Personal_Id, Phone = value.Phone, Address = value.Address, Email = value.Email, Status=value.Status, Position=value.Position };
            //_StaffService.GetStaff().Add(s);     
            //IdCount++;
            //return s;
             _StaffService.PostStaff(value);
        }

        // PUT api/<StaffController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Staff value)
        {
            //Staff foundWorker = _StaffService.GetStaff().Find(w => w.Worker_Number == id);
            //if (foundWorker != null)
            //{
            //    foundWorker.Personal_Id = foundWorker.Personal_Id;
            //    foundWorker.Worker_Number = foundWorker.Worker_Number;
            //    foundWorker.Email = value.Email;
            //    foundWorker.Name = value.Name;
            //    foundWorker.Status = value.Status;
            //    foundWorker.Birth_Date = value.Birth_Date;
            //    foundWorker.Address = value.Address;
            //    foundWorker.Status = value.Status;
            //    foundWorker.Position = value.Position;

            //}
            //return foundWorker;
            _StaffService.PutStaff(id, value);   
        }

        // DELETE api/<StaffController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //    int index = workers.FindIndex((Staff w) => { return w.Worker_Number == id; });
        //    workers.RemoveAt(index);
        //}
    }
}
