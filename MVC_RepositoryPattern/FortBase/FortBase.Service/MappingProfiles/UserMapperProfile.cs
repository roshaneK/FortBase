using AutoMapper;
using FortBase.Repository.Models.UserModels;
using FortBase.Service.Models.UserViewModels;
using System.Collections.Generic;
using System.Linq;

namespace FortBase.Service.MappingProfiles
{
    public class UserMapperProfile : Profile
    {
        public UserMapperProfile()
        {
            CreateMap<UserVM, User>();
            CreateMap<User, UserVM>();
        }
    }
}
