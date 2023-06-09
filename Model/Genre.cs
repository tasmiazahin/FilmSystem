﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace FilmSystem.Model
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        public string?  Title { get; set; }
        public string? Description { get; set; }

        public List<PersonChoice> PersonChoices { get; set; }
    }
}
