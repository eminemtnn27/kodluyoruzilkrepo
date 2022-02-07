using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.BookOperations.GetBooks
{
    public class GetBooksQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public GetBooksQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<BooksViewModel> Handle()
        {
            var bookList = _dbContext.Books.Include(x => x.Genre).OrderBy(a => a.Id).ToList<Book>();
            List<BooksViewModel> view = new List<BooksViewModel>();
            //foreach(var book in bookList)
            //{
            //    view.Add(new BooksViewModel()
            //    {
            //        Title = book.Title,
            //        GenreId = ((GenreEnum)book.GenreId).ToString(),
            //        PublishDate = book.PublishDate.Date.ToString("dd/MM/yyyy"),
            //        PageCount=book.PageCount
            //    });
            //}
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
