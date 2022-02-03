using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.BookOperations.DeleteBook
{
    public class DeleteBookCommand
    {
        private readonly BookStoreDbContext _dbContext;
        public int bookId { get; set; } 
        public DeleteBookCommand(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Handle()
        {
            var book = _dbContext.Books.SingleOrDefault(a => a.Id == bookId);
            if (book is null)
                throw new InvalidOperationException("Silinecek Kitap Bulunamadı"); 
            _dbContext.Books.Remove(book);
            _dbContext.SaveChanges();
        }
    }
    
}
