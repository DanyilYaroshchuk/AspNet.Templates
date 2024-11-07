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
            Database.Migrate();
        }

        public DbSet<TemplateEntitiy> Templates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Add model configurations here if needed
        }
    }
}
