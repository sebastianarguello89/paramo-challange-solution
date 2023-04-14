using Microsoft.EntityFrameworkCore;
using Sat.Recruitment.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sat.Recruitment.DataAccess
{
    public class SatRecruitmentContext : DbContext
    {
        public SatRecruitmentContext(DbContextOptions<SatRecruitmentContext> options) 
            : base(options) 
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NormalUser>();
            modelBuilder.Entity<PremiumUser>();
            modelBuilder.Entity<SuperUser>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
