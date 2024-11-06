using API.Template.BLL.Interfaces;
using API.Template.BLL.DTOs;
using AutoMapper;
using API.Template.DAL.Repositories.Interfaces;
using API.Template.DAL.DataModels;

namespace API.Template.BLL.Services
{
    public class TemplateEntityService : ITemplateEntityService
    {
        private readonly ITemplateEntityRepository _repository;
        private readonly IMapper _mapper;

        public TemplateEntityService(ITemplateEntityRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TemplateEntityDto>> GetAllAsync()
        {
            var entities = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<TemplateEntityDto>>(entities);
        }

        public async Task<TemplateEntityDto> GetByIdAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(id);
            return _mapper.Map<TemplateEntityDto>(entity);
        }

        public async Task AddAsync(TemplateEntityDto dto)
        {
            var entity = _mapper.Map<TemplateEntitiy>(dto);
            await _repository.AddAsync(entity);
        }

        public async Task UpdateAsync(TemplateEntityDto dto)
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
