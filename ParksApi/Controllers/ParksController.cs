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
  public class ParksController : ControllerBase
  {
    private readonly ParksApiContext _db;

    
    public ParksController(ParksApiContext db)
    {
      _db = db;
    }

    // GET: api/Parks
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Park>>> Get(string code, string city, string name, string biggestAirline)
    {
      var query = _db.Parks.AsQueryable();

      if (code != null)
      {
        query = query.Where(entry => entry.Code.Contains(code));
      }

      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }

      if (biggestAirline !=null)
      {
        query = query.Where(entry => entry.BiggestAirline.Contains(biggestAirline));
      }

      return await query.ToListAsync();
    }

    // GET: api/Parks/5
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

    // PUT: api/Parks/5
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

    // POST: api/Parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    // DELETE: api/Parks/5
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