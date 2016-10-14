using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LexiconMovieDB.Models {
    public class Movie {
        public int Id { get; set; }

        [MinLength(1)]
        public string Title { get; set; }

        [Range(0, int.MaxValue, ErrorMessage = "Only positive values!")]
        public int Length { get; set; }
        public Genre Genre { get; set; }

        [Display(Name = "Age Limit")]
        [Range(0, 100, ErrorMessage = "0-18 please!")]
        public int AgeLimit { get; set; }

        [Range(0, 100, ErrorMessage = "0-100 please!")]
        public int MetaScore { get; set; }

        public string LengthInHours { // Kommer inte att läggas in i databasen eftersom den inte har någon setter
            get {
                var hours = Length / 60;
                var minutes = Length - hours * 60;
               
                return $"{hours}:{minutes}"; 
            }
        }
    }

    public enum Genre {
        Drama,
        Horror,
        Comedy,
        [Display(Name ="Drama Comedy")]
        DramaComedy,
        Action
    }
}