using System;
using WebApi.DbOperations;
using WebApi.Entities;
using DevExpress.Xpo;
namespace WebApi.UnitTests.TestSetup
{
    public static class Customers
    {
        public static void AddCustomers(this MovieStoreDbContext context)
        {
            context.Customer.AddRange(
            new Customer
            {
                Name = "emine",
                Surname = "metin"
            },
            new Customer
            {
                Name = "derya",
                Surname = "koç"
            },
            new Customer
            {
                Name = "barış",
                Surname = "deniz"
            }
            );
        } 
    }

}