namespace FilmSystem.Model
{
    public class PersonChoice
    {
        public int Id { get; set; }
        public string? MovieLink { get; set; }
        public int Rating { get; set; }
        public int PersonId { get; set; }
        public int GenreId { get; set; }


        public virtual Person Person { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
