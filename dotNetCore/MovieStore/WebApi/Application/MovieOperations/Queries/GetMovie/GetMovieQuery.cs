using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.MovieOperations.GetMovie 
{
    public class GetMovieQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int MovieId { get; set; }
        public GetMovieQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<MovieViewModel> Handle()
        {
            var movieList = _dbContext.Movie.OrderBy(a => a.MovieId).ToList();
            List<MovieViewModel> view = new List<MovieViewModel>(); 
            return view;
        }
    }
    public class MovieViewModel
    {
        public string Name { get; set; }
        public string GenreId { get; set; }
        public int Price { get; set; }
        public DateTime Year { get; set; }
    }
}
