using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.Application.DirectorOperations.Queries.GetDirectorDetail
{
    public class GetDirectorDetailQuery
    {
        public int DirectorId { get; set; }
        public readonly IMovieStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetDirectorDetailQuery(IMovieStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public DirectorDetailViewModel Handle()
        {
            var director = _context.Director.SingleOrDefault(x=>x.DirectorId == DirectorId);
            if (director is null)
                throw new InvalidOperationException("Yönetmen Bulunamadı! ");
            return _mapper.Map<DirectorDetailViewModel>(director);
        }
    }
    public class DirectorDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string directedMovie { get; set; }
    }
}
