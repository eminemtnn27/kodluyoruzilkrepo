using DevExpress.Xpo;
using FluentAssertions;
using System;
using WebApi.BookOperations.CreateBook;
using WebApi.BookOperations.GetBookDetail;
using WebApi.BookOperations.Queries.GetBookDetail;
using WebApi.BookOperations.UpdateBook;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.BookOperations.Queries.GetBookDetail
{
    public class GetBookDetailQueryValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(  )
        {
            //arrange(hazırlık)
            GetBookDetailQuery command = new GetBookDetailQuery(null, null);
            
            //act(çalıştırma)
            GetBookDetailQueryValidator validator = new GetBookDetailQueryValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErrors()
        {
            GetBookDetailQuery command = new GetBookDetailQuery(null, null);
            
            //act(çalıştırma)
            GetBookDetailQueryValidator validator = new GetBookDetailQueryValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        
      
    }

}