using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi.Entities
{
    public class Movie
    { 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieId { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; } 
        public int GenreId { get; set; }
        public int DirectorId { get; set; }
        public int ActorId { get; set; }
        public Director Director { get; set; }
        public Actor Actor { get; set; }
        public int Price { get; set; }
        public bool IsActive { get; set; } = true;

    }
    public class Genre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
    public class BuyMovie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public int MoviePrice { get; set; }
        public string BuyingMovieCustomerName { get; set; }
        public string BuyingMovieCustomerSurname { get; set; }
        public Customer Customer { get; set; }
        public DateTime BuyYear { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
 

     