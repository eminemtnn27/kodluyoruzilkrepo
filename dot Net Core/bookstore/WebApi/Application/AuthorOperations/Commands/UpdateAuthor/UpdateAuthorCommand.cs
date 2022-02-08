using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.UpdateBook;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.AuthorOperations.Commands.UpdateAuthor
{
    public class UpdateAuthorCommand
    {
        public int AuthorId { get; set; }
        public UpdateAuthorModel Model { get; set; }
        private readonly BookStoreDbContext _context;

        public UpdateAuthorCommand(BookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var author = _context.Author.SingleOrDefault(x => x.Id == AuthorId);
            if (author is null)
                throw new InvalidOperationException("Yazar Bulunamadı?"); 
            if(_context.Genres.Any(x=>x.Name.ToLower()==Model.Name.ToLower() && x.Id!= AuthorId))
                throw new InvalidOperationException("Aynı isimli bir yazar zaten mevcut");
            author.Name = string.IsNullOrEmpty(Model.Name.Trim())? author.Name : Model.Name;
            author.Surname = string.IsNullOrEmpty(Model.Surname.Trim())? author.Surname : Model.Surname;
            author.Birthday = Model.Birthday;
            _context.SaveChanges();
        }

    } 
    public class UpdateAuthorModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

    }
}
