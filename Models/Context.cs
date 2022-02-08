using Microsoft.EntityFrameworkCore;

namespace Registration.Models
{
    public class Context : DbContext
    {
        public DbSet<RegistrationForm> RegistrationForm { get; set; }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
    }
}
