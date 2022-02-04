using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DbOperations;

namespace WebApi.BookOperations.GetBookDetail
{
    public class GetBookDetailQuery
    {
        private readonly BookStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int BookId { get; set; }
        public GetBookDetailQuery(BookStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public BookDetailViewModel Handle()
        {
            var book = _dbContext.Books.Where(book => book.Id == BookId).SingleOrDefault();
            if (book is null)
                throw new InvalidOperationException("Kitap Bulunamadı ");
            BookDetailViewModel view =_mapper.Map<BookDetailViewModel>(book);//new BookDetailViewModel();
            //view.Title = book.Title;
            //view.PageCount = book.PageCount;
            //view.PublishDate = book.PublishDate.Date.ToString("d/MM/yyyy");
            //view.Genre = ((GenreEnum)book.GenreId).ToString();
            return view;
        }
    }
    public class BookDetailViewModel 
    {
        public string Title { get; set; }
        public string Genre { get; set; }
        public int PageCount { get; set; }
        public string PublishDate { get; set; }
    }
}
