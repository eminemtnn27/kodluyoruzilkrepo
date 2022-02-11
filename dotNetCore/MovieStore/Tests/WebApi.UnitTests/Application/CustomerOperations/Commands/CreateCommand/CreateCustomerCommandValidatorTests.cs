using FluentAssertions;
using System;
using WebApi.CustomerOperations.CreateCustomer;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.CustomerOperations.Commands.CreateCommand
{
    public class CreateCustomerCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("emine","m" )]
        [InlineData("emine","metin")]
        [InlineData("","")] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr(string name,string surname)
        {
            //arrange(hazırlık)
            CreateCustomerCommand command = new CreateCustomerCommand(null, null);
            command.Model = new CreateCustomerModel() 
            {
                Name =name,
                Surname=surname
            };

            //act(çalıştırma)
            CreateCustomerCommandValidator validator = new CreateCustomerCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            CreateCustomerCommand command = new CreateCustomerCommand(null, null);
            command.Model = new CreateCustomerModel()
            {
                Name = "Emine",
                Surname = "Metin"
            };

            //act(çalıştırma)
            CreateCustomerCommandValidator validator = new CreateCustomerCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            CreateCustomerCommand command = new CreateCustomerCommand(null, null);
            command.Model = new CreateCustomerModel()
            {
                Name = "Emine",
                Surname = "Metin"
            };

            //act(çalıştırma)
            CreateCustomerCommandValidator validator = new CreateCustomerCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}