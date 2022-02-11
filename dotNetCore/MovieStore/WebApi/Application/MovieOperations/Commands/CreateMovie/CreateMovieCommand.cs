using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.MovieOperations.CreateMovie
{
    public class CreateMovieCommand
    {
        public CreateMovieModel Model { get; set; }
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateMovieCommand(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var movie = _dbContext.Movie.SingleOrDefault(a => a.Name == Model.Name);
            if (movie is not null)
                throw new InvalidOperationException("Film zaten mevcut");
            movie = _mapper.Map<Movie>(Model);

            _dbContext.Movie.Add(movie);
            _dbContext.SaveChanges();
        }
    }
    public class CreateMovieModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GenreId { get; set; }
        public DateTime Year { get; set; }
    } 
}
