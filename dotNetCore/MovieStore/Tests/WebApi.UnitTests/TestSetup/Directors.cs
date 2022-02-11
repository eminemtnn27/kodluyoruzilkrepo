using System;
using WebApi.DbOperations;
using WebApi.Entities;
using DevExpress.Xpo;
namespace WebApi.UnitTests.TestSetup
{
    public static class Directors  
    {
        public static void AddDirectors(this MovieStoreDbContext context)
        {
            context.Director.AddRange(
            new Director { Name = "Christopher Nolan" },
            new Director {Name = "Alejandro Amenábar" },
            new Director {Name = "Denis Villeneuve" }
            );
        } 
    }

}