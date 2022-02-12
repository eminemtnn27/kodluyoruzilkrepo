using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.DbOperations;
using WebApi.TokenOperations;
using WebApi.TokenOperations.Models;

namespace WebApi.Application.UserOperations.Commands.CreateToken
{
    public class CreateTokenCommand  
    {
        public CreateTokenModel Model { get; set; }
        private readonly IMovieStoreDbContext _dbContext;
        private readonly IMapper _mapper;
        private readonly IConfiguration _configuration;
        public CreateTokenCommand(IMovieStoreDbContext dbContext, IMapper mapper, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _configuration=configuration;
        }
        public Token Handle()
        {
            var user = _dbContext.User.SingleOrDefault(a => a.Email == Model.Email && a.Password==Model.Password);
            if (user is not null)
            {
                TokenHandler handler = new TokenHandler(_configuration);
                Token token = handler.CreateAccessToken(user);

                user.RefreshToken = token.RefreshToken;
                user.RefreshTokenExpireDate = token.Expiration.AddMinutes(5);
                _dbContext.SaveChanges();
                return token;
            }
            else    throw new InvalidOperationException("Kullanıcı adı - Şifre Hatalı"); 
        }
    }
    public class CreateTokenModel
    { 
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
