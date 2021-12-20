using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Eroski;
using Eroski.Models;

namespace Eroski.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EroskiController : ControllerBase
    {
        private readonly EroskiContext _context;

        public EroskiController(EroskiContext context)
        {
            _context = context;
        }

        // GET: api/Eroski
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eroski>>> GetEroski()
        {
            return await _context.Eroski.ToListAsync();
        }

        // GET: api/Eroski/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eroski>> GetEroski(string id)
        {
            var eroski = await _context.Eroski.FindAsync(id);

            if (eroski == null)
            {
                return NotFound();
            }

            return eroski;
        }

        // PUT: api/Eroski/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{secc}")]
        public async Task<IActionResult> PutEroski(string secc)
        {
             var eroski = await _context.Eroski.FindAsync(secc);
            eroski.ticket += 1;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EroskiExists(secc))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }
        // PUT: api/Eroski/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("reset")]
        public async Task<IActionResult> Put2Eroski(string secc)
        {
             var eroski = await _context.Eroski.FindAsync(secc);
            eroski.ticket =0;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EroskiExists(secc))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/Eroski/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEroski(string id)
        {
            var eroski = await _context.Eroski.FindAsync(id);
            if (eroski == null)
            {
                return NotFound();
            }

            _context.Eroski.Remove(eroski);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EroskiExists(string id)
        {
            return _context.Eroski.Any(e => e.seccion == id);
        }
    }
}
