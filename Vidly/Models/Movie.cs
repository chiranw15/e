using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
       
        public Genre Genre { get; set; }
        [Required]
        public int GenreId { get; set; }

        [Required]
        public DateTime RealeaseDate { get; set; }
        
          
        [Required]
        public int NumberInStock { get; set; }

       

    }
}