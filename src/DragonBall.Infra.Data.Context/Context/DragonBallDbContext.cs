using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using DragonBall.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonBall.Infra.Data.Context.Context
{
    public class DragonBallDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;
        public DragonBallDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(Configuration.GetConnectionString("Database"));
        }

        public DbSet<Character> Characters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
