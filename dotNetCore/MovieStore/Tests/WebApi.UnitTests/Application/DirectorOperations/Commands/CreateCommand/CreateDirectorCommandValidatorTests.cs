using FluentAssertions;
using WebApi.Application.DirectorOperations.Commands.CreateDirector;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.DirectorOperations.Commands.CreateCommand
{
    public class CreateDirectorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Lord of rings" )]
        [InlineData("")]
        [InlineData("Lor")]
        [InlineData("Lord")]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr(string name )
        {
            //arrange(hazırlık)
            CreateDirectorCommand command = new CreateDirectorCommand(null,null);
            command.Model = new CreateDirectorModel() 
            {
                Name =name
            };

            //act(çalıştırma)
            CreateDirectorCommandValidator validator = new CreateDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            CreateDirectorCommand command = new CreateDirectorCommand(null,null);
            command.Model = new CreateDirectorModel()
            {
                Name = "Lord of rings" 
            };

            //act(çalıştırma)
            CreateDirectorCommandValidator validator = new CreateDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            CreateDirectorCommand command = new CreateDirectorCommand(null,null);
            command.Model = new CreateDirectorModel()
            {
                Name = "Lord of rings" 
            };

            //act(çalıştırma)
            CreateDirectorCommandValidator validator = new CreateDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}