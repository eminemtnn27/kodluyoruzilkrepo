using AutoMapper; 
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetail; 
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;  
        private readonly IMapper _mapper;
        public GetAuthorDetailQueryTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistAuthorTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var author = new Author() { Name = "Test_WhenAlreadyExistAuthorTitleIsGiven_InvalidOperationException_ShouldBeReturn", Surname = "test_author", Birthday = new DateTime(1990, 01, 10) };
            _context.Author.Add(author);
            _context.SaveChanges();

            GetAuthorDetailQuery command = new GetAuthorDetailQuery(_context,_mapper); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Author_ShouldBeCreated()
        {
            GetAuthorDetailQuery command = new GetAuthorDetailQuery(_context, _mapper);
            AuthorDetailViewModel model = new AuthorDetailViewModel() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn", Surname = "test_author", Birthday = new DateTime(1990, 01, 10) };
             

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var author = _context.Author.SingleOrDefault(author => author.Name== model.Name);

            author.Should().NotBeNull();
            author.Surname.Should().Be(model.Surname);
            author.Birthday.Should().Be(model.Birthday);
        }
    }

}