using DevExpress.Xpo;
using FluentAssertions;
using System;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.UpdateBook;
using WebApi.UnitTests.TestSetup;
using Xunit;
using static WebApi.BookOperations.UpdateBook.UpdateBookCommand;

namespace WebApi.UnitTests.Application.BookOperations.Commands.UpdateCommand
{
    public class UpdateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Lord of rings",2)]
        [InlineData("Lord of rings",6)]
        [InlineData("",0)]
        [InlineData("",100)]
        [InlineData("",1)]
        [InlineData("Lor",5)]
        [InlineData("Lord",8)]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErros(string title,int genreId)
        {
            //arrange(hazırlık)
            UpdateBookCommand command = new UpdateBookCommand(null);
            command.Model = new UpdateBookModel() 
            {
                Title =title,  
                GenreId=genreId
            };

            //act(çalıştırma)
            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErrors()
        {
            UpdateBookCommand command = new UpdateBookCommand(null);
            command.Model = new UpdateBookModel()
            {
                Title = "Lord of rings", 
                GenreId = 1
            };

            //act(çalıştırma)
            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErrors()
        {
            UpdateBookCommand command = new UpdateBookCommand(null);
            command.Model = new UpdateBookModel()
            {
                Title = "Lord of rings", 
                GenreId = 1
            };

            //act(çalıştırma)
            UpdateBookCommandValidator validator = new UpdateBookCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}