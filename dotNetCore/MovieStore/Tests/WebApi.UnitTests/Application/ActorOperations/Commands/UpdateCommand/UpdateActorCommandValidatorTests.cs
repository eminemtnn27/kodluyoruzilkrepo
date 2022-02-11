using FluentAssertions;
using WebApi.Application.ActorOperations.Commands.UpdateActor;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.ActorOperations.Commands.UpdateCommand
{
    public class UpdateActorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Lord of rings","")]
        [InlineData("Lord of rings","ff")]
        [InlineData("","")] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturErros(string name,string surname)
        {
            //arrange(hazırlık)
            UpdateActorCommand command = new UpdateActorCommand(null);
            command.Model = new UpdateActorModel() 
            {
                Name = name,
                Surname = surname
            };

            //act(çalıştırma)
            UpdateActorCommandValidator validator = new UpdateActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturErrors()
        {
            UpdateActorCommand command = new UpdateActorCommand(null);
            command.Model = new UpdateActorModel()
            {
                Name = "Nicole", 
                Surname="Kidman"
            };

            //act(çalıştırma)
            UpdateActorCommandValidator validator = new UpdateActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturErrors()
        {
            UpdateActorCommand command = new UpdateActorCommand(null);
            command.Model = new UpdateActorModel()
            {
                Name = "Fyodor",
                Surname = "Dostoyevski"
            };

            //act(çalıştırma)
            UpdateActorCommandValidator validator = new UpdateActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}