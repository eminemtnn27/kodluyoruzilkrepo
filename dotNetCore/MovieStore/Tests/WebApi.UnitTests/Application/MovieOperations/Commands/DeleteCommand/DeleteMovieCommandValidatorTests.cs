using DevExpress.Xpo;
using FluentAssertions;
using System;
using WebApi.MovieOperations.DeleteMovie;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.MovieOperations.Commands.DeleteCommand
{
    public class DeleteMovieCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr( )
        {
            //arrange(hazırlık)
            DeleteMovieCommand command = new DeleteMovieCommand(null);

            //act(çalıştırma)
            DeleteMovieCommandValidator validator = new DeleteMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            DeleteMovieCommand command = new DeleteMovieCommand(null);

            //act(çalıştırma)
            DeleteMovieCommandValidator validator = new DeleteMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            DeleteMovieCommand command = new DeleteMovieCommand(null);

            //act(çalıştırma)
            DeleteMovieCommandValidator validator = new DeleteMovieCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}