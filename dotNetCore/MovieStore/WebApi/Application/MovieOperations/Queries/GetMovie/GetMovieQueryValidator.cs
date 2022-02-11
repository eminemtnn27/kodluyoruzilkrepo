using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 

namespace WebApi.MovieOperations.GetMovie
{
    public class GetMovieQueryValidator : AbstractValidator<GetMovieQuery>
    {
        public GetMovieQueryValidator()
        {
            RuleFor(command => command.MovieId).GreaterThan(0);

        }
    }
}
