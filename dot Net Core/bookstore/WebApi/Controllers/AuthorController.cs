using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.AuthorOperations.Commands.CreateAuthor;
using WebApi.Application.AuthorOperations.Commands.DeleteAuthor;
using WebApi.Application.AuthorOperations.Commands.UpdateAuthor;
using WebApi.Application.AuthorOperations.Queries.GetAuthor;
using WebApi.Application.AuthorOperations.Queries.GetAuthorDetail;
using WebApi.DbOperations; 

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class AuthorController : ControllerBase
    {
        private readonly BookStoreDbContext _context;
        private readonly IMapper _mapper;
        public AuthorController(BookStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
     
        [HttpGet]
        public IActionResult GetAuthor()
        {
            GetAuthorQuery query = new GetAuthorQuery(_context,_mapper);
            var result=query.Handle();
            return Ok(result);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            AuthorDetailViewModel result;
            GetAuthorDetailQuery query = new GetAuthorDetailQuery(_context,_mapper);
            query.AuthorId = id;
            result=query.Handle(); 
            return Ok(result);
        } 
        [HttpPost]
        public IActionResult AddAuthor([FromBody] CreateAuthorModel newAuthor)
        {
            CreateAuthorCommand command = new CreateAuthorCommand(_context,_mapper); 
            command.Model = newAuthor;
            CreateAuthorCommandValidator validator = new CreateAuthorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle(); 
            return Ok(); 
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAuthor(int id,[FromBody] UpdateAuthorModel updatedAuthor)
        {
            UpdateAuthorCommand command = new UpdateAuthorCommand(_context);
            command.AuthorId = id;
            command.Model = updatedAuthor;
            command.Handle(); 
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAuthor(int id)
        {
            DeleteAuthorCommand command = new DeleteAuthorCommand(_context);
            command.AuthorId = id;
            DeleteAuthorCommandValidator validator = new DeleteAuthorCommandValidator();
            validator.ValidateAndThrow(command);
            command.Handle(); 
            return Ok();
        }
    }
}