using FilmSystem.Data;
using FilmSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FilmSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonChoiceController : ControllerBase
    {
        private readonly DataContext _context;

        public PersonChoiceController(DataContext context)
        {

            _context = context;
        }
        // GET: api/<PersonChoiceController>
        [HttpGet]
        public async Task<List<PersonChoice>> Get()
        {
            var personChoice = await _context.PersonChoices.ToListAsync();
            return personChoice;

        }

        // GET api/<PersonChoiceController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PersonChoiceController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PersonChoiceController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/PersonChoiceController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
