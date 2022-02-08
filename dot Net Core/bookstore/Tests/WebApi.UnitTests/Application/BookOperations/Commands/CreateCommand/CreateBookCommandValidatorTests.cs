using DevExpress.Xpo;
using FluentAssertions;
using System;
using WebApi.BookOperations.CreateBook;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Commands.CreateCommand
{
    public class CreateBookCommandValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Theory]
        [InlineData("Lord of rings",0,0)]
        [InlineData("Lord of rings",0,1)]
        [InlineData("",0,0)]
        [InlineData("",100,1)]
        [InlineData("",0,1)]
        [InlineData("Lor",100,1)]
        [InlineData("Lord",100,1)]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErr(string title,int pageCount,int genreId)
        {
            //arrange(hazırlık)
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel() 
            {
                Title =title,
                PageCount=pageCount,
                PublishDate=DateTime.Now.Date.AddYears(-1),
                GenreId=genreId
            };

            //act(çalıştırma)
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErr()
        {
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = "Lord of rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date,
                GenreId = 1
            };

            //act(çalıştırma)
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenValidInputsAreGiven_Validator_ShouldNotBeReturnErr()
        {
            CreateBookCommand command = new CreateBookCommand(null, null);
            command.Model = new CreateBookModel()
            {
                Title = "Lord of rings",
                PageCount = 100,
                PublishDate = DateTime.Now.Date,
                GenreId = 1
            };

            //act(çalıştırma)
            CreateBookCommandValidator validator = new CreateBookCommandValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().Equals(0);
        }
      
    }

}