using AutoMapper;
using DevExpress.Xpo;
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.ActorOperations.Commands.CreateActor;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.ActorOperations.Commands.CreateCommand
{
    public class CreateActorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;  
        private readonly IMapper _mapper;
        public CreateActorCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistActorTitleIsGiven_InvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var actor = new Actor() { Name = "Test_WhenAlreadyExistActorTitleIsGiven_InvalidOperationException_ShouldBeReturn", Surname="test_actor"  };
            _context.Actor.Add(actor);
            _context.SaveChanges();

            CreateActorCommand command = new CreateActorCommand(_context,_mapper);
            command.Model = new CreateActorModel() {Name= actor.Name };

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Oyuncu zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Actor_ShouldBeCreatd()
        {
            CreateActorCommand command = new CreateActorCommand(_context, _mapper);
            CreateActorModel model = new CreateActorModel() { Name = "Hobbit", Surname ="hob"   };
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