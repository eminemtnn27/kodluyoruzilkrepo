using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.Application.ActorOperations.Queries.GetActorDetail
{
    public class GetActorDetailQuery
    {
        public int ActorId { get; set; }
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetActorDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public ActorDetailViewModel Handle()
        {
            var actor = _context.Actor.SingleOrDefault(x=>x.ActorId== ActorId);
            if (actor is null)
                throw new InvalidOperationException("Oyuncu Bulunamadı! ");
            return _mapper.Map<ActorDetailViewModel>(actor);
        }
    }
    public class ActorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ActingMovie { get; set; }
    }
}
