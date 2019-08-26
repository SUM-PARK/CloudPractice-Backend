using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itinere.Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace Itinere.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ItinereDbContext _dbContext;
        public ValuesController(ItinereDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            object result = await this._dbContext.Footprints.ToListAsync().ConfigureAwait(false);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
