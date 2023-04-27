using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DadsJokeController : ControllerBase
    {
        private readonly IDadsJokeInterface dadsJokeInterface;
        public DadsJokeController(IDadsJokeInterface _dadsJokeInterface)
        {
            dadsJokeInterface = _dadsJokeInterface;
        }

        // GET: api/<DadsJokeController>
        [HttpGet]
        public async Task<string> GetDadsJoke()
        {
            var data = await dadsJokeInterface.GetDadsJoke();
            return data;
        }
    }
}
