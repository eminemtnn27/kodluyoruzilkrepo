using AutoMapper;
using DevExpress.Xpo;
using FluentAssertions;
using System;
using System.Linq; 
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.MovieOperations.GetMovieDetail;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.MovieOperations.Queries.GetMovieDetail
{
    public class GetMovieDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;  
        private readonly IMapper _mapper;
        public GetMovieDetailQueryTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var movie = new Movie(){ Name = "Test_WhenAlreadyExistMovieTitleIsGiven_InvalidOperationException_ShouldBeReturn",  Price = 80, Year = new DateTime(2014, 06, 12) };
            _context.Movie.Add(movie);
            _context.SaveChanges();

            GetMovieDetailQuery command = new GetMovieDetailQuery(_context,_mapper); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Film zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Book_ShouldBeCreated()
        {
            GetMovieDetailQuery command = new GetMovieDetailQuery(_context, _mapper);
            MovieDetailViewModel model = new MovieDetailViewModel() { Name = "Interstellar", Price = 80, Year = new DateTime(2014, 06, 12) };
             

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var movie = _context.Movie.SingleOrDefault(movie => movie.Name == model.Name);
            
            movie.Should().NotBeNull();
            movie.Price.Should().Be(model.Price); 
            movie.Year.Should().Be(model.Year);
        }
    }

}