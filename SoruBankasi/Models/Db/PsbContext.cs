using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using SoruBankasi.Models.Data;

namespace SoruBankasi.Models.Db
{
    public class PsbContext : DbContext
    {
        public PsbContext(DbContextOptions<PsbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
