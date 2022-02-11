using FluentAssertions;
using WebApi.Application.DirectorOperations.Commands.UpdateDirector;
using WebApi.UnitTests.TestSetup;
using Xunit; 

namespace WebApi.UnitTests.Application.DirectorOperations.Commands.UpdateCommand
{
    public class UpdateDirectorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Lord of rings")]
        [InlineData("")]
        [InlineData("Lor")]
        [InlineData("Lord")]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErros(string name)
        {
            //arrange(hazırlık)
            UpdateDirectorCommand command = new UpdateDirectorCommand(null);
            command.Model = new UpdateDirectorModel() 
            {
                Name =name 
            };

            //act(çalıştırma)
            UpdateDirectorCommandValidator validator = new UpdateDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErrors()
        {
            UpdateDirectorCommand command = new UpdateDirectorCommand(null);
            command.Model = new UpdateDirectorModel()
            {
                Name = "Lord of rings" 
            };

            //act(çalıştırma)
            UpdateDirectorCommandValidator validator = new UpdateDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErrors()
        {
            UpdateDirectorCommand command = new UpdateDirectorCommand(null);
            command.Model = new UpdateDirectorModel()
            {
                Name = "Lord of rings" 
            };

            //act(çalıştırma)
            UpdateDirectorCommandValidator validator = new UpdateDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}