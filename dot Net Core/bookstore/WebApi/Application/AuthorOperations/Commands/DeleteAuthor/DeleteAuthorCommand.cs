using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand
    {
        public int AuthorId { get; set; }
        private readonly BookStoreDbContext _context;

        public DeleteAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Author.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
                throw new InvalidOperationException("Yazar Bulunamadı?"); 
            _context.Author.Remove(author);
            _context.SaveChanges();
        }

    } 
}
