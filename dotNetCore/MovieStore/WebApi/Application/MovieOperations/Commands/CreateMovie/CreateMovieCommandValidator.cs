using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.MovieOperations.CreateMovie;

namespace WebApi.MovieOperations.CreateMovie
{
    public class CreateMovieCommandValidator : AbstractValidator<CreateMovieCommand>
    {
        public CreateMovieCommandValidator()
        {
            RuleFor(command => command.Model.GenreId).GreaterThan(0);
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(3);
            RuleFor(command => command.Model.Year.Date).NotEmpty().LessThan(DateTime.Now.Date);
            RuleFor(command => command.Model.Surname).NotEmpty().MinimumLength(3);
        }
    }
}
