using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SecuringWebApiUsingApiKey.Attributes;
using Microsoft.AspNetCore.Mvc.Versioning;
using ParksApi.Models;

namespace ParksApi.Controllers
{
  //[ApiKey]
  [ApiController]
  [ApiVersion("1.0")]
  //[Route("api/[controller]")]
  [Route("api/parks")]
  public class ParksV1Controller : ControllerBase
  {
    private readonly ParksApiContext _db;

    
    public ParksV1Controller(ParksApiContext db)
    {
      _db = db;
    }

    // GET: api/parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string name, string description, string state, string area, string visitors, string yearEstablished)
    {
      var query = _db.Parks.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }

      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }

      if (state != null)
      {
        query = query.Where(entry => entry.State.Contains(state));
      }

      if (area != null)
      {
        query = query.Where(entry => entry.Area.Contains(area));
      }

      if (visitors != null)
      {
        query = query.Where(entry => entry.Visitors == Convert.ToInt32(visitors));
      }

      if (yearEstablished != null)
      {
        query = query.Where(entry => entry.YearEstablished == Convert.ToInt32(yearEstablished));
      }


      return await query.ToListAsync();
    }

    // GET: api/parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
        var park = await _db.Parks.FindAsync(id);

        if (park == null)
        {
            return NotFound();
        }

        return park;
    }

    // PUT: api/parks/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }

      _db.Entry(park).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
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

    // POST: api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    // DELETE: api/parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      var park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }
  }
}