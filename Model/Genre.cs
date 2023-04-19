using System.Diagnostics;

namespace FilmSystem.Model
{
    public class Genre
    {
        public int Id { get; set; }
        public string?  Title { get; set; }
        public string? Description { get; set; }

        public List<PersonChoice> PersonChoices { get; set; }
    }
}
