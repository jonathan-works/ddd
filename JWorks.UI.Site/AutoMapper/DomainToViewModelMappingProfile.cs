using AutoMapper;
using JWorks.Domain.Entity;
using JWorks.UI.Site.ViewModel;

namespace JWorks.UI.Site.AutoMapper

{
    public class DomainToViewModelMappingProfile : Profile
    {
        public void AutoMapperProfile()
        {
            CreateMap<UserViewModel, UserEntity>();
        }
    }
}