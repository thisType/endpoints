using AssessmentRest.Dto;
using AssessmentRest.Models;
using AssessmentRest.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssessmentRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase

        
    {
        ServiceUser _serviceuser;

        // GET: api/<ValuesController>
        ValuesController(ServiceUser userservice)
        {

            _serviceuser = userservice;

        }

        

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserOrders(Guid id)
        {
            List<Order> orders = await _serviceuser.GetOrders(id);
            return Ok(orders);

           
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<UserDto> Post([FromBody] UserDto value)
        {
            User user = new User(); 
            user.UserName = value.UserName;

            User added =  await _serviceuser.AddUser(user);
            
            value.UserId = added.UserId;

            return value;


        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
