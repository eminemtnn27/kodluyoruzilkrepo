using FluentAssertions; 
using WebApi.Application.GenreOperations.Commands.CreateGenre; 
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.GenreOperations.Commands.CreateCommand
{
    public class CreateGenreCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Lord of rings" )]
        [InlineData("")]
        [InlineData("Lor")]
        [InlineData("Lord")]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr(string name )
        {
            //arrange(hazırlık)
            CreateGenreCommand command = new CreateGenreCommand(null );
            command.Model = new CreateGenreModel() 
            {
                Name =name
            };

            //act(çalıştırma)
            CreateGenreCommandValidator validator = new CreateGenreCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            CreateGenreCommand command = new CreateGenreCommand(null);
            command.Model = new CreateGenreModel()
            {
                Name = "Lord of rings" 
            };

            //act(çalıştırma)
            CreateGenreCommandValidator validator = new CreateGenreCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            CreateGenreCommand command = new CreateGenreCommand(null);
            command.Model = new CreateGenreModel()
            {
                Name = "Lord of rings" 
            };

            //act(çalıştırma)
            CreateGenreCommandValidator validator = new CreateGenreCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}