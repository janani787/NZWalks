using Microsoft.EntityFrameworkCore;
using NZWalksWebAPI.Models.Domain;
namespace NZWalksWebAPI.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext (DbContextOptions<NZWalksDbContext> options):base(options)
        {

        }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }

        public DbSet<WalkDifficulty> WalksDifficulty { get; set; }


        
        }
    }

