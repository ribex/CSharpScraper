using System.Data.Entity;

namespace Bexcelsa
{
    public class PortfolioContext : DbContext
    {
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Symbol> Symbols { get; set; }
    }
}