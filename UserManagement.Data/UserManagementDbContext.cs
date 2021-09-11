using Microsoft.EntityFrameworkCore;
using UserManagement.Data.Models;

namespace UserManagement.Data
{
    public class UserManagementDbContext : DbContext
    {
        public UserManagementDbContext() { }

        public DbSet<User> Users { get; set; }
    }
}
