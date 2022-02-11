using AutoMapper;
using DevExpress.Xpo;
using FluentAssertions;
using System;
using System.Linq; 
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.MovieOperations.CreateMovie;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.MovieOperations.Commands.CreateCommand
{
    public class CreateMovieCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;  
        private readonly IMapper _mapper;
        public CreateMovieCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistMovieTitleIsGiven_InvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var movie = new Movie() { Name = "Test_WhenAlreadyExistMovieTitleIsGiven_InvalidOperationException_ShouldBeReturn",   Price = 80, Year = new DateTime(2014, 06, 12) };
            _context.Movie.Add(movie);
            _context.SaveChanges();

            CreateMovieCommand command = new CreateMovieCommand(_context,_mapper);
            command.Model = new CreateMovieModel() { Name = movie.Name };

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Film zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Movie_ShouldBeCreatd()
        {
            CreateMovieCommand command = new CreateMovieCommand(_context, _mapper);
            CreateMovieModel model = new CreateMovieModel() { Name = "Interstellar", Year = new DateTime(2014, 06, 12) };
            command.Model = model;

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var movie = _context.Movie.SingleOrDefault(movie => movie.Name == model.Name);
            
            movie.Should().NotBeNull();
            movie.Year.Should().Be(model.Year);
            movie.GenreId.Should().Be(model.GenreId);
        }
    }

}