using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Application.GenreOperations.Queries.GetGenresDetail;

namespace WebApi.Application.GenreOperations.Queries.GetGenreDetail
{
    public class GetGenreDetailQueryValidatior:AbstractValidator<GetGenreDetailQuery>
    {
        public GetGenreDetailQueryValidatior()
        {
            RuleFor(query => query.GenreId).GreaterThan(0);
        }
    }
}
