using Microsoft.EntityFrameworkCore;

namespace UnifyAPI3.Models
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options)
            : base(options)
        {   
        }
    }
}
