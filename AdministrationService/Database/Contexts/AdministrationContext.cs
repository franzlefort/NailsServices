using System;
using System.Linq;
using System.Threading.Tasks;
using AdministrationService.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace AdministrationService.Database.Contexts
{
    public sealed class AdministrationContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Employee> Employees { get; set; }
        
        public AdministrationContext(DbContextOptions<AdministrationContext> options)
            : base(options)
        {
        }

        public async Task<int> SaveChangesAsync()
        {
            return await base.SaveChangesAsync();
        }

        public DbSet<T> DbSet<T>() where T : class
        {
            return Set<T>();
        }

        public new IQueryable<T> Query<T>() where T : class
        {
            return Set<T>();
        }
    }
}