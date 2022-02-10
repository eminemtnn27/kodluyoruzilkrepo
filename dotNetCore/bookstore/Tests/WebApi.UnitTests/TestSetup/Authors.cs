using DevExpress.Xpo;
using System;
using WebApi.DbOperations;
using WebApi.Entities;

namespace WebApi.UnitTests.TestSetup
{
    public static class Authors  
    {
        public static void AddAuthors(this BookStoreDbContext context)
        {
            context.Author.AddRange(
            new Author { Name="Sabahattin",Surname="Ali",Birthday=new DateTime(1907,02,25) },    
            new Author { Name="Fyodor",Surname= "Dostoyevski", Birthday = new DateTime(1821,11,11) },    
            new Author { Name="Lev",Surname="Tolstoy", Birthday = new DateTime(1828,09,09) }    
            );
        } 
    }

}