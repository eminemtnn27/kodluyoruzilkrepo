using AutoMapper; 
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.ActorOperations.Queries.GetActorDetail;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.ActorOperations.Queries.GetActorDetail
{
    public class GetActorDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;  
        private readonly IMapper _mapper;
        public GetActorDetailQueryTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistActorTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var actor = new Actor() { Name = "Test_WhenAlreadyExistAuthorTitleIsGiven_InvalidOperationException_ShouldBeReturn", Surname = "test_actor" };
            _context.Actor.Add(actor);
            _context.SaveChanges();

            GetActorDetailQuery command = new GetActorDetailQuery(_context,_mapper); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Actor_ShouldBeCreated()
        {
            GetActorDetailQuery command = new GetActorDetailQuery(_context, _mapper);
            ActorDetailViewModel model = new ActorDetailViewModel() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn", Surname = "test_actor"  };
             

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var actor = _context.Actor.SingleOrDefault(actor => actor.Name== model.Name);

            actor.Should().NotBeNull();
            actor.Surname.Should().Be(model.Surname); 
        }
    }

}