using Domain.Entities;
using Infrastructure.Map;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Context
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
                    : base(options)
        {
        }

        public DbSet<ContatoEntity> Contato { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContatoMap());
   
            base.OnModelCreating(modelBuilder);
        }

    }
}
