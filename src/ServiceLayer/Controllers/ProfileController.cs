using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Models.Profiles;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace ServiceLayer.Controllers
{
    [Route("api/[controller]")]
    public class ProfileController : Controller
    {
        public IProfileRepository Profile { get; set; }
        public ProfileController(IProfileRepository profile)
        {
            Profile = profile;
        }

        [HttpGet("Test")]
        public IActionResult Test()
        {
            return new ObjectResult("This is a test");
        }

        [HttpGet("{id}", Name = "GetProfile")]
        public IActionResult GetById(string id)
        {
            var profile = Profile.Find(id);
            if (profile == null)
            {
                return NotFound();
            }
            return new ObjectResult(profile);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Profile item)
        {
            if (item == null)
            {
                return BadRequest();
            }
            Profile.Add(item);
            return CreatedAtRoute("GetProfile", new { id = item.ProfileID }, item);
        }

    }
}
