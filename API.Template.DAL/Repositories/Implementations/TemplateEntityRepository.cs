using API.Template.DAL.DataModels;
using API.Template.DAL.Repositories.Interfaces;

namespace API.Template.DAL.Repositories.Implementations
{
    public class TemplateEntityRepository : GenericRepository<TemplateEntitiy>, ITemplateEntityRepository
    {
        public TemplateEntityRepository(TemplateDbContext context) : base(context)
        {
        }

        // Implement any additional methods specific to TemplateEntitiy if needed
    }
}