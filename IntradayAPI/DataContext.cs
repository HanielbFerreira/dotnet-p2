using Microsoft.EntityFrameworkCore;

namespace IntradayAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Operacao> Operacao { get; set; }
    }
}