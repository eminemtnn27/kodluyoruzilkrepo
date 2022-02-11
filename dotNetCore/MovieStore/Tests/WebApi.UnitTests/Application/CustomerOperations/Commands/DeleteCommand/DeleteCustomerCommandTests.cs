using FluentAssertions;
using System;
using WebApi.CustomerOperations.DeleteCustomer;
using WebApi.DbOperations;
using WebApi.Entities;
using WebApi.UnitTests.TestSetup;
using Xunit;

namespace WebApi.UnitTests.Application.CustomerOperations.Commands.DeleteCommand
{
    public class DeleteCustomerCommandTests : IClassFixture<CommonTestFixture>
    {
        private readonly MovieStoreDbContext _context;
        public DeleteCustomerCommandTests(CommonTestFixture testFixture) 
        {
            _context = testFixture.Context; 
        } 
        [Fact]
        public void WhenAlreadyExistCustomerTitleIsGivenInvalidOperationException_ShouldBeRetrn()
        {
            //arrange(hazırlık)
            var customer = new Customer() { Name = "Test_WhenAlreadyExistBookTitleIsGiven_InvalidOperationException_ShouldBeRetrn", Surname ="test_customer" };
            _context.Customer.Remove(customer);
            _context.SaveChanges();

            DeleteCustomerCommand command = new DeleteCustomerCommand(_context); 

            //act(çalıştırma)-assert(doğrulama)
            FluentActions
                .Invoking(() => command.Handle())
                .Should().Throw<InvalidOperationException>().And.Message.Should().Be("Müşteri zaten mevcut. ");
        }

      
    }

}