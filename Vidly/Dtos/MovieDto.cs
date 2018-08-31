using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ReleaseDate { get; set; }

        [Required]
        public DateTime DateAdded { get; set; }

        [Required(ErrorMessage = "Number of Movie must be between 1 and 20.")]
        [Display(Name = "Number in Stock")]
        public byte NumberInStock { get; set; }

        public Genre Genre { get; set; }
        [Display(Name = "Genre")]

        [Required]
        public int GenreId { get; set; }
    }
}