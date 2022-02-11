using FluentAssertions;
using System;
using WebApi.Application.ActorOperations.Commands.CreateActor;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.ActorOperations.Commands.CreateCommand
{
    public class CreateActorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Kidman","Nicole" )]
        [InlineData("kid","man")]
        [InlineData("","")] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr(string name,string surname)
        {
            //arrange(hazırlık)
            CreateActorCommand command = new CreateActorCommand(null, null);
            command.Model = new CreateActorModel() 
            {
                Name =name,
                Surname=surname
            };

            //act(çalıştırma)
            CreateActorCommandValidator validator = new CreateActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            CreateActorCommand command = new CreateActorCommand(null, null);
            command.Model = new CreateActorModel()
            {
                Name = "Nicole",
                Surname = "Kidman"
            };

            //act(çalıştırma)
            CreateActorCommandValidator validator = new CreateActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            CreateActorCommand command = new CreateActorCommand(null, null);
            command.Model = new CreateActorModel()
            {
                Name = "Nicole",
                Surname = "Kidman"
            };

            //act(çalıştırma)
            CreateActorCommandValidator validator = new CreateActorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}