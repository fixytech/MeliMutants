using MeliMutant.Core.Entities;
using MeliMutant.Infrastructure.Data.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeliMutant.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Analysis> Analysis { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AnalysisConfiguration());
        
        }

    }
}
