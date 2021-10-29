using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CatsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public CatsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/cats
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Cat>>> Get(string name, string breed, string gender, int age, int weight)
    {
      var query = _db.Cats.AsQueryable();

      if (name !=null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if (breed !=null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }

      if (gender !=null)
      {
        query = query.Where(entry => entry.Gender == gender);
      }

      if (age !=0)
      {
        query = query.Where(entry => entry.Age == age);
      }

      if (weight !=0)
      {
        query = query.Where(entry => entry.Weight == weight);
      }
  
      return await _db.Cats.ToListAsync();
    }
    //Post api/cats
    [HttpPost]
    public async Task<ActionResult<Cat>> Post(Cat cat)
    {
      _db.Cats.Add(cat);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = cat.CatId }, cat);
    }
    //Get api/cats/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Cat>> GetCat(int id)
    {
      var cat = await _db.Cats.FindAsync(id);
      if (cat == null)
      {
        return NotFound();
      }
      return cat;
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Cat cat)
    {
      if (id != cat.CatId)
      {
        return BadRequest();
      }
      _db.Entry(cat).State = EntityState.Modified;

        try
        {
          await _db.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
          if (!CatExists(id))
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
    //Delete api/cats/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      var cat = await _db.Cats.FindAsync(id);
      if (cat == null)
      {
        return NotFound();
      }
      _db.Cats.Remove(cat);
      await _db.SaveChangesAsync();
      return NoContent();
    }
    private bool CatExists(int id)
    {
      return _db.Cats.Any(cat => cat.CatId == id);
    }
  }
}