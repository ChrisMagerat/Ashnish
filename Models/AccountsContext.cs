using Microsoft.EntityFrameworkCore;


namespace Ashnish.Models
{
    public class AccountsContext : DbContext
    {
        public AccountsContext(DbContextOptions<AccountsContext> options) 
            : base(options) 
        {
        }
        public DbSet<Account> Accounts { get; set; } = null!;

    }
}
