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
  [Route("api/[controller]")]
  public class StatesController : ControllerBase
  {
    private readonly ParksApiContext _db;

    
    public StatesController(ParksApiContext db)
    {
      _db = db;
    }

    // GET: api/states
    [HttpGet]
    public async Task<ActionResult<IEnumerable<State>>> Get(string name, string numberOfParks)

    {
      var query = _db.States.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name.Contains(name));
      }

      if (numberOfParks != null)
      {
        query = query.Where(entry => entry.NumberOfParks == Convert.ToInt32(numberOfParks));
      }

      return await query.ToListAsync();
    }

    // GET: api/states/5
    [HttpGet("{id}")]
    public async Task<ActionResult<State>> GetState(int id)
    {
        var state = await _db.States.FindAsync(id);

        if (state == null)
        {
            return NotFound();
        }

        return state;
    }

    // PUT: api/states/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, State state)
    {
      if (id != state.StateId)
      {
        return BadRequest();
      }

      _db.Entry(state).State = EntityState.Modified;

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!StateExists(id))
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

    // POST: api/states
    [HttpPost]
    public async Task<ActionResult<State>> Post(State state)
    {
      _db.States.Add(state);
      await _db.SaveChangesAsync();

      return CreatedAtAction(nameof(GetState), new { id = state.StateId }, state);
    }

    // DELETE: api/states/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteState(int id)
    {
      var state = await _db.States.FindAsync(id);
      if (state == null)
      {
        return NotFound();
      }

      _db.States.Remove(state);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    private bool StateExists(int id)
    {
      return _db.States.Any(e => e.StateId == id);
    }
  }
}