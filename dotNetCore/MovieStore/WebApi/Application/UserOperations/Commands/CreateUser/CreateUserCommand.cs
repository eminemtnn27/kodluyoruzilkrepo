using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.Application.UserOperations.Commands.CreateUser
{
    public class CreateUserCommand  
    { 
        public CreateUserModel Model { get; set; }
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        public CreateUserCommand(IMovieStoreDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }
        public void Handle()
        {
            var user = _dbContext.User.SingleOrDefault(a => a.Email == Model.Email);
            if (user is not null)
                throw new InvalidOperationException("Kullanıcı zaten mevcut");
            user = _mapper.Map<User>(Model);
             _dbContext.User.Add(user);
            _dbContext.SaveChanges();
        }
    }
    public class CreateUserModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
