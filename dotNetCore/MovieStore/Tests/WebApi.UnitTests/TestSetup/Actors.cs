using System;
using WebApi.DbOperations;
using WebApi.Entities;
using DevExpress.Xpo;
namespace WebApi.UnitTests.TestSetup
{
    public static class Actors  
    {
        public static void AddActors(this MovieStoreDbContext context)
        {
            context.Actor.AddRange(
            new Actor { Name = "Nicole Kidman" },
            new Actor { Name = "Timothée Chalamet"},
            new Actor { Name = "Matthew McConaughey" }
            );
        } 
    }

}