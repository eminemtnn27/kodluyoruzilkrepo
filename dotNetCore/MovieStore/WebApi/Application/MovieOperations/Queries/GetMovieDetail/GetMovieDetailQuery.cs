using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DbOperations;

namespace WebApi.MovieOperations.GetMovieDetail
{
    public class GetMovieDetailQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int MovieId { get; set; }
        public GetMovieDetailQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public MovieDetailViewModel Handle()
        {
            var movie = _dbContext.Movie.Include(x=>x.GenreId).Where(movie => movie.MovieId == MovieId).SingleOrDefault();
            if (movie is null)
                throw new InvalidOperationException("Film Bulunamadı ");
            MovieDetailViewModel view =_mapper.Map<MovieDetailViewModel>(movie); 
            return view;
        }
    }
    public class MovieDetailViewModel
    {
        public string Name { get; set; }
        public string GenreId { get; set; }
        public int Price { get; set; }
        public DateTime Year { get; set; }
    }
}
