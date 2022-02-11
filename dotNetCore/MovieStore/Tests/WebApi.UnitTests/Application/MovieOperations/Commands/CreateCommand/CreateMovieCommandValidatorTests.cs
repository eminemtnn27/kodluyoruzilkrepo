using DevExpress.Xpo;
using FluentAssertions;
using System;
using WebApi.MovieOperations.CreateMovie;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.MovieOperations.Commands.CreateCommand
{
    public class CreateMovieCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Lord of rings")]
        [InlineData("Lord of ring")]
        [InlineData("")]
        [InlineData("Lor")]
        [InlineData("Lord")]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr(string name )
        {
            //arrange(hazırlık)
            CreateMovieCommand command = new CreateMovieCommand(null, null);
            command.Model = new CreateMovieModel() 
            {
                Name =name,
                Year=DateTime.Now.Date.AddYears(-1)
            };

            //act(çalıştırma)
            CreateMovieCommandValidator validator = new CreateMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            CreateMovieCommand command = new CreateMovieCommand(null, null);
            command.Model = new CreateMovieModel()
            {
                Name = "Lord of rings",
                Year = DateTime.Now.Date,
            };

            //act(çalıştırma)
            CreateMovieCommandValidator validator = new CreateMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            CreateMovieCommand command = new CreateMovieCommand(null, null);
            command.Model = new CreateMovieModel()
            {
                Name = "Lord of rings",
                Year = DateTime.Now.Date 
            };

            //act(çalıştırma)
            CreateMovieCommandValidator validator = new CreateMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}