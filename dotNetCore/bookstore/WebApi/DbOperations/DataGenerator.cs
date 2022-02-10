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
            using(var context=new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }
                context.Genres.AddRange(
                    new Genre
                    {
                        Name = "Personal Growth"
                    },
                    new Genre
                    {
                        Name = "Sicence Fiction",
                    },
                    new Genre
                    {
                        Name = "Romance"
                    }
                );
                context.Books.AddRange(
                new Book
                { 
                    Title="Learn Startup",
                    GenreId=1, //Personal growth
                    PageCount=200,
                    PublishDate=new DateTime(2001,06,12)
                },
                new Book
                { 
                    Title="Herland",
                    GenreId=2, //Science fiction
                    PageCount=250,
                    PublishDate=new DateTime(2010,05,23)
                },
                new Book
                { 
                    Title="Dune",
                    GenreId=2, //Science fiction
                    PageCount=540,
                    PublishDate=new DateTime(2001,12,21)
                });
                context.SaveChanges();
            };
        }
    }
}
