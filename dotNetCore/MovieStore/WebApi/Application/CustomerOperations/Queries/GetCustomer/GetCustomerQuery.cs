using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Common;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.CustomerOperations.GetCustomer
{
    public class GetCustomerQuery
    {
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public int CustomerId { get; set; }
        public GetCustomerQuery(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public List<CustomerViewModel> Handle()
        {
            var customerList = _dbContext.Customer.OrderBy(a => a.CustomerId).ToList<Customer>();
            List<CustomerViewModel> view = new List<CustomerViewModel>(); 
            return view;
        }
    }
    public class CustomerViewModel
    {
        public string Name { get; set; }
        public string GenreId { get; set; }
        public string Surname { get; set; }
        public int Price { get; set; }
        public DateTime Year { get; set; }
    }
}
