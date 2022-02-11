using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.MovieOperations.DeleteMovie
{
    public class DeleteMovieCommand
    {
        private readonly IMovieStoreDbContext _context;
        public int MovieId { get; set; } 
        public DeleteMovieCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var movie = _context.Movie.SingleOrDefault(a => a.MovieId == MovieId);
            if (movie is null)
                throw new InvalidOperationException("Silinecek Film Bulunamadı");
            movie.IsActive = false;
            _context.Movie.Update(movie);
            _context.SaveChanges();
        }
    }
    
}
