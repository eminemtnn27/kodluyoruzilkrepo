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
        private readonly IBookStoreDbContext _context;
        public int bookId { get; set; } 
        public DeleteBookCommand(IBookStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var book = _context.Books.SingleOrDefault(a => a.Id == bookId);
            if (book is null)
                throw new InvalidOperationException("Silinecek Kitap Bulunamadı");
            _context.Books.Remove(book);
            _context.SaveChanges();
        }
    }
    
}
