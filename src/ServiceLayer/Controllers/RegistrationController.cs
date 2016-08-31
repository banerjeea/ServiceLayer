using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Models.Registration;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    public class RegistrationController : Controller
    {
        public IRegistrationRepository Registration { get; set; }
        public RegistrationController(IRegistrationRepository registration)
        {
            Registration = registration;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public async Task<ActionResult> Register([FromBody] Registration item)
        {
            if (item == null)
            {
                return BadRequest();
            }

            
            Registration.Add(item);
            return CreatedAtRoute("GetProfile", new { id = item.RegistrationNumber }, item);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
