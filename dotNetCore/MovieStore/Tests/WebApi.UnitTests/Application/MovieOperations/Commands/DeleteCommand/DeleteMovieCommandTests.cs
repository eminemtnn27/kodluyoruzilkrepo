using AutoMapper;
using DevExpress.Xpo;
using FluentAssertions;
using System;
using System.Linq; 
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.MovieOperations.DeleteMovie;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.MovieOperations.Commands.DeleteCommand
{
    public class DeleteMovieCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;
        public DeleteMovieCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context; 
        } 
        [Fact]
        public void WhenAlreadyExistBookTitleIsGivenInvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var movie = new Movie() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeRetrn", Price = 80, Year = new DateTime(2014, 06, 12) };
            _context.Movie.Remove(movie);
            _context.SaveChanges(); 
            DeleteMovieCommand command = new DeleteMovieCommand(_context); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Film zaten mevcut. ");
        }

      
    }

}