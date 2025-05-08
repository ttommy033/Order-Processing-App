using ControllerProblem.Models;
using Microsoft.EntityFrameworkCore;

namespace ControllerProblem.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
        public DbSet<Order> Orders { get; set; }
    }
}
