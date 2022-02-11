using FluentAssertions;
using WebApi.Application.ActorOperations.Commands.DeleteActor;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.ActorOperations.Commands.DeleteCommand
{
    public class DeleteActorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr( )
        {
            //arrange(hazırlık)
            DeleteActorCommand command = new DeleteActorCommand(null);

            //act(çalıştırma)
            DeleteActorCommandValidator validator = new DeleteActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            DeleteActorCommand command = new DeleteActorCommand(null);

            //act(çalıştırma)
            DeleteActorCommandValidator validator = new DeleteActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            DeleteActorCommand command = new DeleteActorCommand(null);

            //act(çalıştırma)
            DeleteActorCommandValidator validator = new DeleteActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}