using Microsoft.EntityFrameworkCore;
using SimpleCRM.Models;

namespace SimpleCRM.Data
{
    // 👇 This MUST be public and inherit from DbContext
    public class CrmContext : DbContext
    {
        public CrmContext(DbContextOptions<CrmContext> options)
            : base(options)
        {
        }

        // This will become the Clients table in the database
        public DbSet<Client> Clients { get; set; }
    }
}
