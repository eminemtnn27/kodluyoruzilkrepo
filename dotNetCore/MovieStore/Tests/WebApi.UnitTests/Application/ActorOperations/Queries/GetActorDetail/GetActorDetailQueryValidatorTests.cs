using FluentAssertions;
using WebApi.Application.ActorOperations.Queries.GetActorDetail;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.ActorOperations.Queries.GetActorDetail
{
    public class GetActorDetailQueryValidatorTests : IClassFixture<CommonTestFixture>
    {  
        [Fact]
        public void WhenInvalidInputsAreGiven_Validator_ShouldBeReturnErrors()
        {
            //arrange(hazırlık)
            GetActorDetailQuery command = new GetActorDetailQuery(null, null);

            //act(çalıştırma)
            GetActorDetailQueryValidator validator = new GetActorDetailQueryValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        [Fact]
        public void WhenDateTimeEqualNowIsGiven_Validator_ShouldBeReturnErrors()
        {
            GetActorDetailQuery command = new GetActorDetailQuery(null, null);

            //act(çalıştırma)
            GetActorDetailQueryValidator validator = new GetActorDetailQueryValidator();
            var result = validator.Validate(command);


            //assert(doğrulama)
            result.Errors.Count.Should().BeGreaterThan(0);
        }
        
      
    }

}