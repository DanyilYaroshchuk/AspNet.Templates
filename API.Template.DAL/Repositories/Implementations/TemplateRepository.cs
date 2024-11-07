using API.Template.DAL.DataModels;
using API.Template.DAL.Repositories.Interfaces;

namespace API.Template.DAL.Repositories.Implementations
{
    public class TemplateRepository : GenericRepository<TemplateEntitiy>, ITemplateRepository
    {
        public TemplateRepository(TemplateDbContext context) : base(context)
        {
        }

        // Implement any additional methods specific to TemplateEntitiy if needed
    }
}