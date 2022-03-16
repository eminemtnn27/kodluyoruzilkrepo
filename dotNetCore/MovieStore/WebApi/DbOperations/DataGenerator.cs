using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using WebApi.Entities;

namespace WebApi.DbOperations
{
    public class DataGenerator  
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using(var context=new MovieStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<MovieStoreDbContext>>()))
            {
                if(context.Movie.Any())
                {
                    return;
                }
                context.Genre.AddRange(
                    new Genre
                    {
                        Id=1,
                        Name = "Bilim Kurgu/Macera"
                    },
                    new Genre
                    {
                        Id = 2,
                        Name = "Korku",
                    },
                    new Genre
                    {
                        Id = 3,
                        Name = "Gerilim"
                    }
                );
                context.Director.AddRange(
                    new Director
                    {
                        Name = "Christopher Nolan",
                        Surname="",
                        directedMovie="interstellar"
                    },
                    new Director
                    {
                        Name = "Alejandro",
                        Surname = " Amenábar",
                        directedMovie = "The Others"
                    },
                    new Director
                    {
                        Name = "Denis",
                        Surname = "Villeneuve",
                        directedMovie = "Dune"
                    }
                );
                context.Movie.AddRange(
                    new Movie
                    { 
                        Name="Interstellar",
                        GenreId=1,  
                        DirectorId=1,  
                        ActorId=3,  
                        Price=80,
                        Year=new DateTime(2014,06,12)
                    },
                    new Movie
                    { 
                        Name="The Others",
                        GenreId=2,
                        DirectorId = 2,
                        ActorId = 1,
                        Price =50,
                        Year=new DateTime(2001,05,23)
                    },
                    new Movie
                    { 
                        Name="Dune",
                        GenreId=3,
                        DirectorId = 3,
                        ActorId = 2,
                        Price =54,
                        Year=new DateTime(2021,12,21)
                    });
                context.Actor.AddRange(
                    new Actor
                    {
                        Name = "Nicole Kidman",
                    
                    },
                    new Actor
                    {
                        Name = "Timothée Chalamet",
                     
                    },
                    new Actor
                    {
                        Name = "Matthew McConaughey",
                     
                    });
                //context.Orders.AddRange(
                //   new BuyMovie
                //   { 
                //       MovieId =2,
                //       BuyingMovieCustomerName="emine",
                //       BuyingMovieCustomerSurname="metin",
                //       MoviePrice = 50
                //   },
                //   new BuyMovie
                //   {
                //       MovieId = 3,
                //       BuyingMovieCustomerName = "derya",
                //       BuyingMovieCustomerSurname = "koç",
                //       MoviePrice=54
                //   },
                //   new BuyMovie
                //   {
                //       MovieId = 1,
                //       BuyingMovieCustomerName = "barış",
                //       BuyingMovieCustomerSurname = "deniz",
                //       MoviePrice = 80
                //   });
                context.Customer.AddRange(
                   new Customer
                   {
                       Name="emine",
                       Surname="metin",
                       boughtMovie= "Interstellar",
                       favMovie= "Interstellar"
                   },
                   new Customer
                   {
                       Name = "derya",
                       Surname = "koç",
                       boughtMovie = "Dune",
                       favMovie = "Dune"
                   },
                   new Customer
                   {
                       Name = "barış",
                       Surname = "deniz",
                       boughtMovie = "The Others",
                       favMovie = "The Others"
                   }
                );
                context.SaveChanges();
            };
        }
    }
}
 