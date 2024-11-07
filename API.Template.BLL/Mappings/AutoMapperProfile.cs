using AutoMapper;
using API.Template.BLL.DTOs;
using API.Template.DAL.DataModels;

namespace API.Template.BLL.Mappings
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<TemplateEntitiy, TemplateDto>().ReverseMap();
        }
    }
}
