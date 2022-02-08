using AutoMapper; 
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.GenreOperations.Queries.GetGenresDetail;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.GenreOperations.Queries.GetGenreDetail
{
    public class GetGenreDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly BookStoreDbContext _context;  
        private readonly IMapper _mapper;
        public GetGenreDetailQueryTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistGenreTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var genre = new Genre() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn", Id = 1   };
            _context.Genres.Add(genre);
            _context.SaveChanges();

            GetGenreDetailQuery command = new GetGenreDetailQuery(_context,_mapper); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldBeCreated()
        {
            GetGenreDetailQuery command = new GetGenreDetailQuery(_context, _mapper);
            GenreDetailViewModel model = new GenreDetailViewModel() { Name= "Hobbit", Id = 1000 };
             

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var genre = _context.Genres.SingleOrDefault(genre => genre.Name == model.Name);
            
            genre.Should().NotBeNull();
            genre.Name.Should().Be(model.Name);  
        }
    }

}