using FluentAssertions;
using WebApi.Application.DirectorOperations.Queries.GetDirectorDetail;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.DirectorOperations.Queries.GetDirectorDetail
{
    public class GetDirectorDetailQueryValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors(  )
        {
            //arrange(hazırlık)
            GetDirectorDetailQuery command = new GetDirectorDetailQuery(null, null);

            //act(çalıştırma)
            GetDirectorDetailQueryValidator validator = new GetDirectorDetailQueryValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErrors()
        {
            GetDirectorDetailQuery command = new GetDirectorDetailQuery(null, null);

            //act(çalıştırma)
            GetDirectorDetailQueryValidator validator = new GetDirectorDetailQueryValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        
      
    }

}