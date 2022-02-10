using AutoMapper;
using DevExpress.Xpo;
using FluentAssertions;
using System;
using System.Linq;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.GetBookDetail;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Queries.GetBookDetail
{
    public class GetBookDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;  
        private readonly IMapper _mapper;
        public GetBookDetailQueryTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var book = new Book() { Title = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn", GenreId = 1, PageCount = 100, PublishDate = new DateTime(1990, 01, 10) };
            _context.Books.Add(book);
            _context.SaveChanges();

            GetBookDetailQuery command = new GetBookDetailQuery(_context,_mapper); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldBeCreated()
        {
            GetBookDetailQuery command = new GetBookDetailQuery(_context, _mapper);
            BookDetailViewModel model = new BookDetailViewModel() { Title = "Hobbit", PageCount = 1000 };
             

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var book = _context.Books.SingleOrDefault(book => book.Title == model.Title);
            
            book.Should().NotBeNull();
            book.PageCount.Should().Be(model.PageCount); 
            book.Genre.Should().Be(model.Genre);
            book.Title.Should().Be(model.Title);
        }
    }

}