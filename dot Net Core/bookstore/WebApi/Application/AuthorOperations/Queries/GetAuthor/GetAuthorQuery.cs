using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.Application.AuthorOperations.Queries.GetAuthor
{
    public class GetAuthorQuery
    {
        public readonly BookStoreDbContext _context;
        public readonly IMapper _mapper;

        public GetAuthorQuery(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<AuthorViewModel> Handle()
        {
            var author = _context.Author.OrderBy(x=>x.Id);
            List<AuthorViewModel> returnObj = _mapper.Map<List<AuthorViewModel>>(author);
            return returnObj;
        }
    }
    public class AuthorViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
