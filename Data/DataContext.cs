using FilmSystem.Model;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Security.Claims;

namespace FilmSystem.Data
{
    public class DataContext :  DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Person> Persons { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PersonChoice> PersonChoices { get; set; }
    }
}
