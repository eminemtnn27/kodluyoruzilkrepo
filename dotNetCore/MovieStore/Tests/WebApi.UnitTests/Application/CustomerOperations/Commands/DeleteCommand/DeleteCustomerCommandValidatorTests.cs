using FluentAssertions;
using WebApi.CustomerOperations.DeleteCustomer;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.CustomerOperations.Commands.DeleteCommand
{
    public class DeleteCustomerCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr( )
        {
            //arrange(hazırlık)
            DeleteCustomerCommand command = new DeleteCustomerCommand(null);

            //act(çalıştırma)
            DeleteCustomerCommandValidator validator = new DeleteCustomerCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            DeleteCustomerCommand command = new DeleteCustomerCommand(null);

            //act(çalıştırma)
            DeleteCustomerCommandValidator validator = new DeleteCustomerCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            DeleteCustomerCommand command = new DeleteCustomerCommand(null);

            //act(çalıştırma)
            DeleteCustomerCommandValidator validator = new DeleteCustomerCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}