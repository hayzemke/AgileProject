using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    public DbSet<Character> Characters { get; set; }
        public DbSet<Animals> Animals { get; set; }
        public DbSet<GreenThumbLevel> GreenThumbLevels { get; set; }
        public DbSet<FarmerType> FarmerTypes { get; set; }
}