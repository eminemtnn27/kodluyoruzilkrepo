using AutoMapper; 
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.DirectorOperations.Commands.CreateDirector;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.DirectorOperations.Commands.CreateCommand
{
    public class CreateDirectorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;
        private readonly IMapper _mapper;
        public CreateDirectorCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context; 
            _mapper= testFixture.Mapper; 
        } 
        [Fact]
        public void WhenAlreadyExistDirectorTitleIsGiven_InvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var director = new Director() { Name = "Test_WhenAlreadyExistDirectorTitleIsGiven_InvalidOperationException_ShouldBeReturn" };
            _context.Director.Add(director);
            _context.SaveChanges();

            CreateDirectorCommand command = new CreateDirectorCommand(_context,_mapper );
            command.Model = new CreateDirectorModel() { Name = director.Name };

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yönetmen Zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Director_ShouldBeCreatd()
        {
            CreateDirectorCommand command = new CreateDirectorCommand(_context,_mapper );
            CreateDirectorModel model = new CreateDirectorModel() { Name = "Hobbit"};
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