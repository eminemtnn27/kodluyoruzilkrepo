using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.CustomerOperations.CreateCustomer
{
    public class CreateCustomerCommand 
    {
        public CreateCustomerModel Model { get; set; }
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateCustomerCommand(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var customer = _dbContext.Customer.SingleOrDefault(a => a.Name == Model.Name);
            if (customer is not null)
                throw new InvalidOperationException("Müşteri zaten mevcut");
            customer = _mapper.Map<Customer>(Model);

            _dbContext.Customer.Add(customer);
            _dbContext.SaveChanges();
        }
    }
    public class CreateCustomerModel
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
    } 
}
