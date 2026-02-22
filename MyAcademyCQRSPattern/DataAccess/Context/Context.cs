using Microsoft.EntityFrameworkCore;
using MyAcademyCQRSPattern.DataAccess.Entities;

namespace MyAcademyCQRSPattern.DataAccess.Context
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
