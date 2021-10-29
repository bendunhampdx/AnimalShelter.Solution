using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using AnimalShelter.Models;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DogsController : ControllerBase
  {
    private readonly AnimalShelterContext _db;

    public DogsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // GET api/dogs
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Dog>>> Get()
    {
      return await _db.Dogs.ToListAsync();
    }
    // Post api/dogs
    [HttpPost]
    public async Task<ActionResult<Dog>> Post(Dog dog)
    {
      _db.Dogs.Add(dog);
      await _db.SaveChangesAsync();
      return CreatedAtAction("Post", new { id = dog.DogId }, dog);
    }

    // GET api/dogs/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Dog>> GetDog(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);
      if (dog == null)
      {
        return NotFound();
      }
      return dog;
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Dog dog)
    {
      if (id != dog.DogId)
      {
        return BadRequest();
      }
      _db.Entry(dog).State = EntityState.Modified;
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
    // DELETE api/dogs/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
      var dog = await _db.Dogs.FindAsync(id);
      if (dog == null)
      {
        return NotFound();
      }
      _db.Dogs.Remove(dog);
      await _db.SaveChangesAsync();
      return NoContent();
    }
    private bool CatExists(int id)
    {
      return _db.Dogs.Any(dog => dog.DogId == id);
    }
  }
}