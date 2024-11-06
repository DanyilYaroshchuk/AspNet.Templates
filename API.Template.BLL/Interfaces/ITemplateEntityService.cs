using API.Template.BLL.DTOs;

namespace API.Template.BLL.Interfaces
{
    public interface ITemplateEntityService
    {
        Task<IEnumerable<TemplateEntityDto>> GetAllAsync();
        Task<TemplateEntityDto> GetByIdAsync(long id);
        Task AddAsync(TemplateEntityDto dto);
        Task UpdateAsync(TemplateEntityDto dto);
        Task DeleteAsync(long id);
    }
}
