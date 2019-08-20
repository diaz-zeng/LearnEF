using System;
using LearnEf.Domains;
using LearnEF.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace LearnEF.Data
{
    public class MyContext : DbContext
    {
        // public MyContext(DbContextOptions<MyContext> options) : base(options)
        // {

        // }
        public DbSet<Company> Companies
        {
            get;
            set;
        }

        public DbSet<Department> Departments
        {
            get;
            set;
        }

        public DbSet<CompanyCity> CompanyCities
        {
            get;
            set;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CompanyCity>().HasKey(c => new { c.CityId, c.CompanyId });
            modelBuilder.Entity<CompanyCity>().HasOne(x => x.Company).WithMany(x => x.CompanyCities).HasForeignKey(x => x.CompanyId);
            modelBuilder.Entity<CompanyCity>().HasOne(x => x.City).WithMany(x => x.CompanyCities).HasForeignKey(x => x.CityId);
            modelBuilder.Entity<Owner>().HasOne(x => x.Company).WithOne(x => x.Owner).HasForeignKey<Owner>(x => x.CompanyId);
        }

        public readonly LoggerFactory MyLoggerFactory = new LoggerFactory(new[]{
            new ConsoleLoggerProvider((category,level)=>
                category==DbLoggerCategory.Database.Command.Name && level==LogLevel.Information,true)
        });

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseSqlServer("Server=localhost;Database=LearnEF;User Id=sa;Password=Zly19981026.");
            optionsBuilder.UseLoggerFactory(MyLoggerFactory).EnableSensitiveDataLogging(true).UseSqlServer("Server=localhost;Database=LearnEF;User Id=sa;Password=Zly19981026.");
        }


    }
}
