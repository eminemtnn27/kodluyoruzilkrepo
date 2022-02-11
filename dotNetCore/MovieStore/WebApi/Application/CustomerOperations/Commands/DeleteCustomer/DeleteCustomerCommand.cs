using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;

namespace WebApi.CustomerOperations.DeleteCustomer
{
    public class DeleteCustomerCommand
    {
        private readonly IMovieStoreDbContext _context;
        public int CustomerId { get; set; } 
        public DeleteCustomerCommand(IMovieStoreDbContext context)
        {
            _context = context;
        }
        public void Handle()
        {
            var customer = _context.Customer.SingleOrDefault(a => a.CustomerId == CustomerId);
            if (customer is null)
                throw new InvalidOperationException("Silinecek Müşteri Bulunamadı"); 
            _context.Customer.Update(customer);
            _context.SaveChanges();
        }
    }
    
}
