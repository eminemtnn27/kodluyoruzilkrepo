using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DbOperations;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext;
        public GetBooksQuery(BookStoreDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public List<BooksViewModel> Handle()
        {
            var bookList = _dbContext.Books.OrderBy(a => a.Id).ToList<Book>();
            List<BooksViewModel> view = new List<BooksViewModel>();
            foreach(var book in bookList)
            {
                view.Add(new BooksViewModel()
                {
                    Title = book.Title,
                    GenreId = ((GenreEnum)book.GenreId).ToString(),
                    PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy"),
                    PageCount=book.PageCount
                });
            }
            return view;
        }
    }
    public class BooksViewModel
    {
        public string Title { get; set; }    
        public int PageCount { get; set; }    
        public string PublishDate { get; set; }    
        public string GenreId { get; set; }    
    }
}
