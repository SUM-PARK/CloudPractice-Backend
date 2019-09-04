using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itinere.Infrastructure.Ef;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Itinere.API.Command;
using Itinere.Infrastructure.Model;

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

        [HttpPost()]
        public async Task Post([FromBody]string name)
        {
            var footPrint = new Footprint() {
                Name = name,
                MorningDung = new Dung() { Solidity = 3 },
                CoffeeTimes = new List<CoffeeTime>() { new CoffeeTime() { When = DateTime.Now, With = "지성책임/혜수책임/etc.." } }
            };

            this._dbContext.Footprints.Add(footPrint);

            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);   
        }

        [HttpPost("json")]
        public async Task Post([FromBody] CreateFootprintCommand command)
        {
            var footPrint = new Footprint() { Name = command.Name, MorningDung = new Dung() { Solidity = 3 } };

            this._dbContext.Footprints.Add(footPrint);

            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        [HttpPut("{id}")]
        public async Task Put(string id, [FromBody]string value)
        {
            Footprint footprint = await this._dbContext.Footprints.FirstOrDefaultAsync(o => o.Id == id).ConfigureAwait(false);

            footprint.Name = value;

            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);
        }

        [HttpDelete("{id}")]
        public async Task Delete(string id)
        {
            Footprint footprint = await this._dbContext.Footprints.FirstOrDefaultAsync(o => o.Id == id).ConfigureAwait(false);

            this._dbContext.Footprints.Remove(footprint);

            await this._dbContext.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
