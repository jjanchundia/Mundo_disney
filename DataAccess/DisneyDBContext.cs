using Microsoft.EntityFrameworkCore;
using Mundo_disney.Models.DataModels;

namespace Mundo_disney.DataAccess
{
    public class DisneyDBContext:DbContext
    {
        public DisneyDBContext(DbContextOptions<DisneyDBContext> options):base(options)
        {

        }

        //DbSet
        public DbSet<Users>? User { get; set; }
        public DbSet<Movie>? Movie { get; set; }
        public DbSet<Character>? Character { get; set; }
        public DbSet<Gender>? Gender { get; set; }
    }
}