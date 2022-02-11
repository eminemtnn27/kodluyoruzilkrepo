using AutoMapper;
using DevExpress.Xpo;
using FluentAssertions;
using System;
using System.Linq;
using WebApi.CustomerOperations.CreateCustomer;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.CustomerOperations.Commands.CreateCommand
{
    public class CreateCustomerCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;  
        private readonly IMapper _mapper;
        public CreateCustomerCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context;
            _mapper = testFixture.Mapper;
        } 
        [Fact]
        public void WhenAlreadyExistvTitleIsGiven_InvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var customer = new Customer() { Name = "Test_WhenAlreadyExistCustomerTitleIsGiven_InvalidOperationException_ShouldBeReturn", Surname="test_customer"};
            _context.Customer.Add(customer);
            _context.SaveChanges();

            CreateCustomerCommand command = new CreateCustomerCommand(_context,_mapper);
            command.Model = new CreateCustomerModel() {Name= customer.Name };

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Müşteri zaten mevcut. ");
        }

        [Fact]
        public void WhenValidInputsAreGiven_Author_ShouldBeCreatd()
        {
            CreateCustomerCommand command = new CreateCustomerCommand(_context, _mapper);
            CreateCustomerModel model = new CreateCustomerModel() { Name = "Hobbit", Surname ="hob"   };
            command.Model = model;

            //act
            FluentActions
               .Invoking(() => command.Handle()).Invoke();
            //assert
            var customer = _context.Customer.SingleOrDefault(customer => customer.Name == model.Name);
            
            customer.Should().NotBeNull();
            customer.Surname.Should().Be(model.Surname); 
        }
    }

}