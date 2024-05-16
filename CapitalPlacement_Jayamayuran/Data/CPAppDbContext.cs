using CapitalPlacement_Jayamayuran.Models;
using Microsoft.EntityFrameworkCore;

namespace CapitalPlacement_Jayamayuran.Data
{
    public class CPAppDbContext : DbContext 
    {
        public CPAppDbContext(DbContextOptions<CPAppDbContext> options) : base(options) 
        {
            
        }

        
        public DbSet<Question> Questions { get; set; }

        public DbSet<_Programm> Programs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Question>()
                .ToContainer("Questions")
                .HasPartitionKey(x => x.Type)
                .HasNoDiscriminator()
                .HasKey(x => x.Qid);

            modelBuilder.Entity<_Programm>()
                .ToContainer("Programs")
                .HasPartitionKey(x=>x.Program_ID)
                .HasNoDiscriminator()
                .HasKey(x=>x.Program_ID);
        }
    }
}
