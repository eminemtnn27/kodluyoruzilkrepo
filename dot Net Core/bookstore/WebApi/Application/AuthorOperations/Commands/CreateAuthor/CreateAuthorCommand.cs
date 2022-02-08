using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.CreateAuthor
{
    public class CreateAuthorCommand
    {
        public CreateAuthorModel Model { get; set; }
        private readonly BookStoreDbContext _context;

        public CreateAuthorCommand(BookStoreDbContext context, AutoMapper.IMapper _mapper)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Author.SingleOrDefault(x => x.Name == Model.Name);
            if (author is null)
                throw new InvalidOperationException("Yazar Zaten Mevcut.");
            author = new Author();
            author.Name = Model.Name;
            _context.Author.Add(author);
            _context.SaveChanges();
        }

    }
    public class CreateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
