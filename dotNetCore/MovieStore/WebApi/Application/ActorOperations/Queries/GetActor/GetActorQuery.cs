using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.Application.ActorOperations.Queries.GetActor
{
    public class GetActorQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetActorQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<ActorViewModel> Handle()
        {
            var actor = _context.Actor.OrderBy(x=>x.ActorId);
            List<ActorViewModel> returnObj = _mapper.Map<List<ActorViewModel>>(actor);
            return returnObj;
        }
    }
    public class ActorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ActingMovie { get; set; }
    }
}
