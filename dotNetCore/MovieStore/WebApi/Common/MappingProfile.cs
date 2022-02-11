using AutoMapper; 
using WebApi.Entities;
using WebApi.MovieOperations.CreateMovie;
using WebApi.MovieOperations.GetMovie;
using WebApi.MovieOperations.GetMovieDetail;

namespace WebApi.Common
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<CreateMovieModel, Movie>();
            CreateMap<Movie, MovieDetailViewModel>().ForMember(dest => dest.GenreId, opt => opt.MapFrom(src => src.GenreId));
            CreateMap<Movie, MovieViewModel>().ForMember(dest => dest.GenreId, opt => opt.MapFrom(src => src.GenreId));
             
        }
    }

}