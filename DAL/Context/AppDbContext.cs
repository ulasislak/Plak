using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class AppDbContext:DbContext
    {
        public DbSet<AnaBölüm> AnaBölüms { get; set; }
        public DbSet<Yönetici> Yöneticis { get; set; }
        public DbSet<YöneticiAnaBölüm> YöneticiAnaBölüms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=192.168.1.135;database=PlakDb;uid=sa;pwd=Password1.;trusted_connection=true;trustservercertificate=true");
        }
    }
}
