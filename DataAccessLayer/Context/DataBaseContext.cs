using EntityLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class DataBaseContext:DbContext
    {
        public DataBaseContext()
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=SAWRNTGOYZLM6\\SQLEXPRESS;Database=RentGoWebAppDb;Trusted_Connection=True;TrustServerCertificate=True",
                 b => b.MigrationsAssembly("DataAccessLayer"));
        }
        public DbSet<Authority> Authorities { get; set; }
        public DbSet<AuthorityGroup> AuthorityGroups { get; set; }
        public DbSet<AuthorityGroupWithUser> AuthorityGroupWithUsers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Program> Programs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
