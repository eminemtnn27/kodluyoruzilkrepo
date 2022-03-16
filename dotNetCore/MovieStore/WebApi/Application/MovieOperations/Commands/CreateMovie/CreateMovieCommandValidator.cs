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
            RuleFor(command => command.Model.GenreId);
            RuleFor(command => command.Model.Name).NotEmpty().MinimumLength(3);
            RuleFor(command => command.Model.Year.Date).LessThan(DateTime.Now.Date); 
        }
    }
}
