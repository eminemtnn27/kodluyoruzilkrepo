using AutoMapper;
using DevExpress.Xpo;
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.BookOperations.CreateBook;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.AuthorOperations.Commands.CreateCommand
{
    public class CreateAuthorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;  
        private readonly IMapper _mapper;
        public CreateAuthorCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistAuthorTitleIsGiven_InvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var author = new Author() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn",Surname="test_author", Birthday = new DateTime(1990, 01, 10) };
            _context.Author.Add(author);
            _context.SaveChanges();

            CreateAuthorCommand command = new CreateAuthorCommand(_context,_mapper);
            command.Model = new CreateAuthorModel() {Name= author.Name };

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yazar zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Author_ShouldBeCreatd()
        {
            CreateAuthorCommand command = new CreateAuthorCommand(_context, _mapper);
            CreateAuthorModel model = new CreateAuthorModel() { Name = "Hobbit", Surname ="hob" , Birthday= DateTime.Now.Date.AddYears(-1) };
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