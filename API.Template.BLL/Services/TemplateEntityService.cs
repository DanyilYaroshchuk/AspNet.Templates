using API.Template.BLL.Interfaces;
using API.Template.BLL.DTOs;
using AutoMapper;
using API.Template.DAL.Repositories.Interfaces;
using API.Template.DAL.DataModels;

namespace API.Template.BLL.Services
{
    public class TemplateEntityService : ITemplateService
    {
        private readonly ITemplateRepository _repository;
        private readonly IMapper _mapper;

        public TemplateEntityService(ITemplateRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TemplateDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TemplateDto>>(entities);
        }

        public async Task<TemplateDto> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TemplateDto>(entity);
        }

        public async Task AddAsync(TemplateDto dto)
        {
            var entity = _mapper.Map<TemplateEntitiy>(dto);
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(TemplateDto dto)
        {
            var entity = _mapper.Map<TemplateEntitiy>(dto);
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(long id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
