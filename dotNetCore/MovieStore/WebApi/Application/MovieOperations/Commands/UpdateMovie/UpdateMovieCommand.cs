using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.MovieOperations.UpdateMovie
{
    public class UpdateMovieCommand  
    {
        private readonly IMovieStoreDbContext _context;
        public int MovieId { get; set; }
        public UpdateMovieModel Model { get; set; }
        public UpdateMovieCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var movie = _context.Movie.SingleOrDefault(a => a.MovieId == MovieId);
            if (movie is null)
                throw new InvalidOperationException("Güncellenecek film Bulunamadı");
            movie.GenreId = Model.GenreId != default ? Model.GenreId : movie.GenreId; 
            movie.Name = Model.Name != default ? Model.Name : movie.Name;
            _context.SaveChanges(); 
        }
        public class UpdateMovieModel
        {
            public string Name { get; set; }
            public int GenreId { get; set; } 
            public DateTime Year { get; set; } 
        }
    }
}
