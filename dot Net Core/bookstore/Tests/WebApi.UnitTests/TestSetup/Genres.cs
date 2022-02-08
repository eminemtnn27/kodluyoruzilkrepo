using DevExpress.Xpo;
using System;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.UnitTests.TestSetup
{
    public static class Genres  
    {
        public static void AddGenres(this BookStoreDbContext context)
        {
            context.Genres.AddRange(
            new Genre { Name = "Personal Growth" },    
            new Genre { Name = "Sicence Fiction", },    
            new Genre { Name = "Romance" }    
            );
        } 
    }

}