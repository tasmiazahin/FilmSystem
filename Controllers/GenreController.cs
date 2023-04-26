using FilmSystem.Data;
using FilmSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FilmSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GenreController : ControllerBase
    {
        private readonly DataContext _context;

        public GenreController(DataContext context)
        {

            _context = context;
        }
        // GET: api/<GenreController>
        [HttpGet]
        public async Task<List<Genre>> Get()
        {
            var genre = await _context.Genres.ToListAsync();
            return genre;
           
        }

        // GET api/<GenreController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<GenreController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<GenreController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<GenreController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
