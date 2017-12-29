using AutoMapper;
using JWorks.Domain.Entity;
using JWorks.UI.Site.ViewModel;

namespace JWorks.UI.Site.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public void AutoMapperProfile()
        {
            CreateMap<UserEntity, UserViewModel>();
        }
    }
}