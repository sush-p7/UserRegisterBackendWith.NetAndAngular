using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace ECommerceBackend.Models
{
    public class UserContext: DbContext
    {
        public UserContext(DbContextOptions options): base(options)
        {
            
        }
        public DbSet<User> Users { get; set; }
    }
}
