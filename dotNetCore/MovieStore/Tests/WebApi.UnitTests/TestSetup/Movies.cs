using System;
using WebApi.DbOperations;
using WebApi.Entities;
using DevExpress.Xpo;
namespace WebApi.UnitTests.TestSetup
{
    public static class Movies  
    {
        public static void AddMovies(this MovieStoreDbContext context)
        {
            context.Movie.AddRange(
             new Movie
             {
                 Name = "Interstellar",
                 GenreId = 1,
                 DirectorId = 1,
                 ActorId = 3,
                 Price = 80,
                 Year = new DateTime(2014, 06, 12)
             },
            new Movie
            {
                Name = "The Others",
                GenreId = 2,
                DirectorId = 2,
                ActorId = 1,
                Price = 50,
                Year = new DateTime(2001, 05, 23)
            },
            new Movie
            {
                Name = "Dune",
                GenreId = 1,
                DirectorId = 3,
                ActorId = 2,
                Price = 54,
                Year = new DateTime(2021, 12, 21)
            }
            );
        } 
    }

}