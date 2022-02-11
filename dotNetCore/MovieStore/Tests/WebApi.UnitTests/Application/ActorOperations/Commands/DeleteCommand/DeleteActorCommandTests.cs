using FluentAssertions;
using System;
using WebApi.Application.ActorOperations.Commands.DeleteActor;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.ActorOperations.Commands.DeleteCommand
{
    public class DeleteActorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;
        public DeleteActorCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context; 
        } 
        [Fact]
        public void WhenAlreadyExistActorTitleIsGivenInvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var actor = new Actor() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeRetrn", Surname ="test_actor"  };
            _context.Actor.Remove(actor);
            _context.SaveChanges();

            DeleteActorCommand command = new DeleteActorCommand(_context); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Oyuncu zaten mevcut. ");
        }

      
    }

}