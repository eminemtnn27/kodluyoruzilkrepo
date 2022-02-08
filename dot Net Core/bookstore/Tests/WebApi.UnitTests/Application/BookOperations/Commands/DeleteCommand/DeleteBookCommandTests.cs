using AutoMapper;
using DevExpress.Xpo;
using FluentAssertions;
using System;
using System.Linq;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.DeleteBook;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Commands.DeleteCommand
{
    public class DeleteBookCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;
        public DeleteBookCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context; 
        } 
        [Fact]
        public void WhenAlreadyExistBookTitleIsGivenInvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var book = new Book() { Title = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeRetrn", GenreId = 1, PageCount = 100, PublishDate = new DateTime(1990, 01, 10) };
            _context.Books.Remove(book);
            _context.SaveChanges();

            DeleteBookCommand command = new DeleteBookCommand(_context); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap zaten mevcut. ");
        }

      
    }

}