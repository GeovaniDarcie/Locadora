using Api.Models.Directors;
using Api.Models.Movies;
using Microsoft.EntityFrameworkCore;

namespace Api.Models
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
    }
}