using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ASPCoreServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessangerController : ControllerBase
    {
        

        // GET api/<MessangerController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "hochu v VDV " + id.ToString();
        }

        // POST api/<MessangerController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

    }
}
