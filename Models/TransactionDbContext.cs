using Microsoft.EntityFrameworkCore;

namespace JupiterX.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {
            
        }

        public DbSet<Transaction> Transactions { get; set; }
    }
}
