using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using DatingApp.API.Controllers.Data;
using Microsoft.EntityFrameworkCore;

namespace DatingApp.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        private readonly DataContext _context;
        public ValuesController(DataContext context)
        {
            _context = context;

        }
        //GET: api/values
        [HttpGet]
        public async Task<IActionResult> GetValues()
        {
            var values = await _context.Values.ToListAsync();
            return Ok(values);
        }

        //GET: api/values/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetValue(int id)
        {
            var value = await _context.Values.FirstOrDefaultAsync(c => c.Id == id);
            return Ok(value);

        }

        //Post: api/value
        [HttpPost]
        public void Post([FromBody] string value) { }


        //PUT: api/value/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value) { }

        //Delete: api/value/id
        [HttpDelete("{id}")]
        public void Delete(int id) { }



    }
}