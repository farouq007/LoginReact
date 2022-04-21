using LoginReact.Model;
using Microsoft.EntityFrameworkCore;

namespace LoginReact.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<User> UsersLogin { get; set; }
    }
}