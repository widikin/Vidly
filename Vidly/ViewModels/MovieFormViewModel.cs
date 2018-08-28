using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Security;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }
       // public Movie Movie { get; set; }

        //This allows to initialise the form with null values
        public int ?Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Release Date")]
        public DateTime ? ReleaseDate { get; set; }


        [Required(ErrorMessage = "Number of Movie must be between 1 and 20.")]
        [Display(Name = "Number in Stock")]
        public byte? NumberInStock { get; set; }

      
        [Display(Name = "Genre")]
        [Required]
        public int ? GenreId { get; set; }


        public string Title
        {
            get
            {
                return Id != 0 ? "Edit Movie" : "New Movie";
            }
        }

        public MovieFormViewModel()
        {
            //used when creating new Movie
            Id = 0;
        }
        //used when updating the Movie
        public MovieFormViewModel(Movie movie)
        {
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.NumberInStock;
            GenreId = movie.GenreId;
        }
    }
}