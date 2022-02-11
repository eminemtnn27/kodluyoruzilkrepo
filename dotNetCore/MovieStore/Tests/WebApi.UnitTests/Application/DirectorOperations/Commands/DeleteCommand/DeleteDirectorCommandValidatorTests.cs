using FluentAssertions;
using WebApi.Application.DirectorOperations.Commands.DeleteDirector;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.DirectorOperations.Commands.DeleteCommand
{
    public class DeleteDirectorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr( )
        {
            //arrange(hazırlık)
            DeleteDirectorCommand command = new DeleteDirectorCommand(null);

            //act(çalıştırma)
            DeleteDirectorCommandValidator validator = new DeleteDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            DeleteDirectorCommand command = new DeleteDirectorCommand(null);

            //act(çalıştırma)
            DeleteDirectorCommandValidator validator = new DeleteDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            DeleteDirectorCommand command = new DeleteDirectorCommand(null);

            //act(çalıştırma)
            DeleteDirectorCommandValidator validator = new DeleteDirectorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}