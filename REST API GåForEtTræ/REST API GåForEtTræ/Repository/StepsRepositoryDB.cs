using Microsoft.EntityFrameworkCore;
using REST_API_GåForEtTræ.Model;

namespace REST_API_GåForEtTræ.Repository
{
    public class StepsRepositoryDB : DbContext
    {
        public StepsRepositoryDB(DbContextOptions<StepsRepositoryDB> options) : base(options) { }

        public DbSet<Steps> Steps { get; set; }
    }
}
