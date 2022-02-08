using FluentAssertions; 
using WebApi.Application.AuthorOperations.Commands.DeleteAuthor;  
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.AuthorOperations.Commands.DeleteCommand
{
    public class DeleteAuthorCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr( )
        {
            //arrange(hazırlık)
            DeleteAuthorCommand command = new DeleteAuthorCommand(null);

            //act(çalıştırma)
            DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            DeleteAuthorCommand command = new DeleteAuthorCommand(null);

            //act(çalıştırma)
            DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            DeleteAuthorCommand command = new DeleteAuthorCommand(null);

            //act(çalıştırma)
            DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}