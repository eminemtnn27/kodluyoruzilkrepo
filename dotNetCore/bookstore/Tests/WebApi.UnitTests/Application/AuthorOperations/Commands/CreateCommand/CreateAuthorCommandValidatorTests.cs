using FluentAssertions;
using System;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor; 
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.AuthorOperations.Commands.CreateCommand
{
    public class CreateAuthorBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Dostoyevski","fyodor" )]
        [InlineData("Dosto","yevski")]
        [InlineData("","")] 
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr(string name,string surname)
        {
            //arrange(hazırlık)
            CreateAuthorCommand command = new CreateAuthorCommand(null, null);
            command.Model = new CreateAuthorModel() 
            {
                Name =name,
                Surname=surname,
                Birthday=DateTime.Now.Date.AddYears(-1) 
            };

            //act(çalıştırma)
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            CreateAuthorCommand command = new CreateAuthorCommand(null, null);
            command.Model = new CreateAuthorModel()
            {
                Name = "Dostoyevski",
                Surname = "Fyodor",
                Birthday = DateTime.Now.Date
            };

            //act(çalıştırma)
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            CreateAuthorCommand command = new CreateAuthorCommand(null, null);
            command.Model = new CreateAuthorModel()
            {
                Name = "Fyodor",
                Surname = "Dostoyevski",
                Birthday = DateTime.Now.Date
            };

            //act(çalıştırma)
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}