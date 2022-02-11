
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.DbOperations{
    public interface IMovieStoreDbContext
    {
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Customer> Customer { get; set; }
        int SaveChanges();
    }
}