using Microsoft.EntityFrameworkCore;

namespace AngServices.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options)
      : base(options)
        {
        }
        public DbSet<Pessoa> Pessoa { get; set; }

    }
}