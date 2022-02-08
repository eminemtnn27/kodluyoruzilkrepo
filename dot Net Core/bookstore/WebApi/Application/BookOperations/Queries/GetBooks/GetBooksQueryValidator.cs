using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.BookOperations.GetBooks;

namespace WebApi.BookOperations.UpdateBook
{
    public class GetBooksQueryValidator : AbstractValidator<GetBooksQuery>
    {
        public GetBooksQueryValidator()
        {
            RuleFor(command => command.BookId).GreaterThan(0);

        }
    }
}
