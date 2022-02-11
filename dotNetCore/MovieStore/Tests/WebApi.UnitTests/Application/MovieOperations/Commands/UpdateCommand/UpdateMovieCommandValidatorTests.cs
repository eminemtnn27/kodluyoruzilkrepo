using DevExpress.Xpo;
using FluentAssertions;
using System;
using WebApi.MovieOperations.UpdateMovie;
using WebApi.UnitTests.TestSetup;
using Xunit;
using static WebApi.MovieOperations.UpdateMovie.UpdateMovieCommand;

namespace WebApi.UnitTests.Application.MovieOperations.Commands.UpdateCommand
{
    public class UpdateMovieCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Lord of rings",2)]
        [InlineData("Lord of rings",6)] 
        [InlineData("",1)]
        [InlineData("Lor",5)]
        [InlineData("Lord",8)]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErros(string name,int genreId)
        {
            //arrange(hazırlık)
            UpdateMovieCommand command = new UpdateMovieCommand(null);
            command.Model = new UpdateMovieModel() 
            {
                Name =name,  
                GenreId=genreId
            };

            //act(çalıştırma)
            UpdateMovieCommandValidator validator = new UpdateMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErrors()
        {
            UpdateMovieCommand command = new UpdateMovieCommand(null);
            command.Model = new UpdateMovieModel()
            {
                Name = "Lord of rings", 
                GenreId = 1
            };

            //act(çalıştırma)
            UpdateMovieCommandValidator validator = new UpdateMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErrors()
        {
            UpdateMovieCommand command = new UpdateMovieCommand(null);
            command.Model = new UpdateMovieModel()
            {
                Name = "Lord of rings", 
                GenreId = 1
            };

            //act(çalıştırma)
            UpdateMovieCommandValidator validator = new UpdateMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}