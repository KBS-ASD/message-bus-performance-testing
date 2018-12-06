using System.Collections.Generic;
using KBS.Controller.Models;
using KBS.FauxApplication;
using KBS.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace KBS.Controller.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IManager _manager;

        public TestController(IManager manager){
            _manager = manager;
        }

        // GET api/test
        [HttpGet]
        [ProducesResponseType(404)]
        public List<TestEnvironment> GetAll()
        {
            //return _manager.GetTests();
            return null;
        }

        // Get api/test/{id}
        [HttpGet, Route("{id}")]
        [ProducesResponseType(404)]
        public TestEnvironment GetTest(int id){
            //return _manager.GetTest(id);
            return null;
        }

        // POST api/test
        [HttpPost]
        [ProducesResponseType(400)]
        public ActionResult Post([FromBody] TestConfiguration configuration)
        {
            // _manager.CreateTest(configuration);
            //return Ok();
            return BadRequest();
        }

    }
}