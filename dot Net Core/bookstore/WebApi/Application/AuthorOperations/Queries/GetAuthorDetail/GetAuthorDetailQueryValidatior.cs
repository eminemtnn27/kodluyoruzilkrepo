using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;  

namespace WebApi.Application.AuthorOperations.Queries.GetAuthorDetail
{
    public class GetAuthorDetailQueryValidatior : AbstractValidator<GetAuthorDetailQuery>
    {
        public GetAuthorDetailQueryValidatior()
        {
            RuleFor(query => query.AuthorId).GreaterThan(0);
        }
    }
}
