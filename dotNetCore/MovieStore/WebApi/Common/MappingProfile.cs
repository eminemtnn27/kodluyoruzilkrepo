using AutoMapper;
using WebApi.Application.ActorOperations.Queries.GetActor;
using WebApi.Application.ActorOperations.Queries.GetActorDetail;
using WebApi.Application.DirectorOperations.Queries.GetDirector;
using WebApi.Application.DirectorOperations.Queries.GetDirectorDetail;
using WebApi.CustomerOperations.CreateCustomer;
using WebApi.CustomerOperations.GetCustomer;
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
            CreateMap<Actor, ActorDetailViewModel>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ActorId));
            CreateMap<Actor, ActorViewModel>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.ActorId));
            CreateMap<Director, DirectorDetailViewModel>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DirectorId));
            CreateMap<Director, DirectorViewModel>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.DirectorId)); 
            CreateMap<Customer, CustomerViewModel>().ForMember(dest => dest.GenreId, opt => opt.MapFrom(src => src.CustomerId));

        }
    }

}