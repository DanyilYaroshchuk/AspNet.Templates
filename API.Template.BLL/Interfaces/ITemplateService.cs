using API.Template.BLL.DTOs;

namespace API.Template.BLL.Interfaces
{
    public interface ITemplateService
    {
        Task<IEnumerable<TemplateDto>> GetAllAsync();
        Task<TemplateDto> GetByIdAsync(long id);
        Task AddAsync(TemplateDto dto);
        Task UpdateAsync(TemplateDto dto);
        Task DeleteAsync(long id);
    }
}
