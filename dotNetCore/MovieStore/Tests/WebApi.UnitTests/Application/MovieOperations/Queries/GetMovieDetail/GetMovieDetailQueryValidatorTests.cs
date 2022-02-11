using DevExpress.Xpo;
using FluentAssertions;
using System;
using WebApi.MovieOperations.GetMovieDetail;
using WebApi.MovieOperations.Queries.GetMovieDetail;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.MovieOperations.Queries.GetMovieDetail
{
    public class GetMovieDetailQueryValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(  )
        {
            //arrange(hazırlık)
            GetMovieDetailQuery command = new GetMovieDetailQuery(null, null);

            //act(çalıştırma)
            GetMovieDetailQueryValidator validator = new GetMovieDetailQueryValidator();
            var result = validator.Validate(command);

            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErrors()
        {
            GetMovieDetailQuery command = new GetMovieDetailQuery(null, null);

            //act(çalıştırma)
            GetMovieDetailQueryValidator validator = new GetMovieDetailQueryValidator();
            var result = validator.Validate(command);

            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        
      
    }

}