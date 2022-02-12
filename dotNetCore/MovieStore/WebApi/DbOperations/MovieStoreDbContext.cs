
using Microsoft.EntityFrameworkCore;
using WebApi.Entities;

namespace WebApi.DbOperations{
    public class MovieStoreDbContext : DbContext, IMovieStoreDbContext
    {
        public MovieStoreDbContext(DbContextOptions<MovieStoreDbContext> options):base(options)
        {}
        public DbSet<Movie> Movie { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Director> Director { get; set; }
        public DbSet<Actor> Actor { get; set; }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<BuyMovie> Orders { get; set; }
        public DbSet<User> User { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}