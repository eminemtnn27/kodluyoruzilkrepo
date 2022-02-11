using FluentAssertions;
using System;
using WebApi.Application.DirectorOperations.Commands.DeleteDirector;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.DirectorOperations.Commands.DeleteCommand
{
    public class DeleteDirectorCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;
        public DeleteDirectorCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context; 
        } 
        [Fact]
        public void WhenAlreadyExistDirectorTitleIsGivenInvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var director = new Director() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeRetrn"  };
            _context.Director.Remove(director);
            _context.SaveChanges();

            DeleteDirectorCommand command = new DeleteDirectorCommand(_context); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yönetmen zaten mevcut. ");
        }

      
    }

}