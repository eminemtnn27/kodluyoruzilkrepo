using AutoMapper; 
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.DirectorOperations.Commands.UpdateDirector;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit; 

namespace WebApi.UnitTests.Application.DirectorOperations.Commands.UpdateCommand
{
    public class UpdateDirectorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;  
        private readonly IMapper _mapper;
        public UpdateDirectorCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistGenreTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var director = new Director() { Name = "Test_WhenAlreadyExistGenreTitleIsGiven_InvalidOperationException_ShouldBeReturn"  };
            
            _context.SaveChanges();

            UpdateDirectorCommand command = new UpdateDirectorCommand(_context);
            command.Model = new UpdateDirectorModel() { Name = director.Name };

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yönetmen zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Director_ShouldBeUpdated()
        {
            UpdateDirectorCommand command = new UpdateDirectorCommand(_context);
            UpdateDirectorModel model = new UpdateDirectorModel() { Name = "Hobbit"  };
            command.Model = model;

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var director = _context.Director.SingleOrDefault(director => director.Name == model.Name);
            
            director.Should().NotBeNull();
            director.Name.Should().Be(model.Name);  
        }
    }

}