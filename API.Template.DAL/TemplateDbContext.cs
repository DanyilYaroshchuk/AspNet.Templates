using API.Template.DAL.DataModels;
using Microsoft.EntityFrameworkCore;

namespace API.Template.DAL
{
    public class TemplateDbContext : DbContext
    {
        public TemplateDbContext(DbContextOptions<TemplateDbContext> options)
            : base(options)
        {
            // Ensure the database is created from the model
            Database.EnsureCreated();
        }

        public DbSet<TemplateEntitiy> TemplateEntities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add model configurations here if needed
        }
    }
}
