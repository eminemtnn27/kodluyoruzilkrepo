using AutoMapper; 
using FluentAssertions;
using System;
using System.Linq;
using WebApi.Application.DirectorOperations.Queries.GetDirectorDetail;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.DirectorOperations.Queries.GetDirectorDetail
{
    public class GetDirectorDetailQueryTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;  
        private readonly IMapper _mapper;
        public GetDirectorDetailQueryTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistGenreTitleIsGiven_InvalidOperationException_ShouldBeReturn()
        {
            //arrange(hazırlık)
            var director = new Director() { Name = "Test_WhenAlreadyExistDirectorTitleIsGiven_InvalidOperationException_ShouldBeReturn" };
            _context.Director.Add(director);
            _context.SaveChanges();

            GetDirectorDetailQuery command = new GetDirectorDetailQuery(_context,_mapper); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Yönetmen zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Director_ShouldBeCreated()
        {
            GetDirectorDetailQuery command = new GetDirectorDetailQuery(_context, _mapper);
            DirectorDetailViewModel model = new DirectorDetailViewModel() { Name= "Hobbit", Id = 1000 };
             
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