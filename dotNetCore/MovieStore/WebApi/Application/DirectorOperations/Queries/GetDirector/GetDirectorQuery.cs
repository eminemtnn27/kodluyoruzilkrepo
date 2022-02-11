using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.Application.DirectorOperations.Queries.GetDirector
{
    public class GetDirectorQuery
    {
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetDirectorQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<DirectorViewModel> Handle()
        {
            var director = _context.Director.OrderBy(x=>x.DirectorId);
            List<DirectorViewModel> returnObj = _mapper.Map<List<DirectorViewModel>>(director);
            return returnObj;
        }
    }
    public class DirectorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string directedMovie { get; set; }
    }
}
