using AutoMapper; 
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.ActorOperations.Commands.UpdateActor;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit; 

namespace WebApi.UnitTests.Application.ActorOperations.Commands.UpdateCommand
{
    public class UpdateActorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;  
        private readonly IMapper _mapper;
        public UpdateActorCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistActorTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var actor = new Actor() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeReturn", Surname = "test_actor"  };
            
            _context.SaveChanges();

            UpdateActorCommand command = new UpdateActorCommand(_context);
            command.Model = new UpdateActorModel() { Name = "Hobbit", Surname = "test_author"  };

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Kitap zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Actor_ShouldBeUpdated()
        {
            UpdateActorCommand command = new UpdateActorCommand(_context);
            UpdateActorModel model = new UpdateActorModel() { Name = "Hobbit", Surname = "test_author"  };
            command.Model = model;

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var actor = _context.Actor.SingleOrDefault(actor => actor.Name == model.Name);
            
            actor.Should().NotBeNull();
            actor.Surname.Should().Be(model.Surname);  
        }
    }

}