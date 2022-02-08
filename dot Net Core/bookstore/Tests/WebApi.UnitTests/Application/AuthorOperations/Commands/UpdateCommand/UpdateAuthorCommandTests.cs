using AutoMapper; 
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.AuthorOperations.Commands.UpdateAuthor;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit; 

namespace WebApi.UnitTests.Application.AuthorOperations.Commands.UpdateCommand
{
    public class UpdateAuthorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;  
        private readonly IMapper _mapper;
        public UpdateAuthorCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistAuthorTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var author = new Author() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn", Surname = "test_author", Birthday = new DateTime(1990, 01, 10) };
            
            _context.SaveChanges();

            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.Model = new UpdateAuthorModel() { Name = "Hobbit", Surname = "test_author", Birthday = new DateTime(1990, 01, 10) };

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Author_ShouldBeUpdated()
        {
            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            UpdateAuthorModel model = new UpdateAuthorModel() { Name = "Hobbit", Surname = "test_author", Birthday = new DateTime(1990, 01, 10) };
            command.Model = model;

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var author = _context.Author.SingleOrDefault(author => author.Name == model.Name);
            
            author.Should().NotBeNull();
            author.Surname.Should().Be(model.Surname); 
            author.Birthday.Should().Be(model.Birthday);
        }
    }

}