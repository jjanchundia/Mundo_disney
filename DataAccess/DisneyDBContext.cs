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
    }
}