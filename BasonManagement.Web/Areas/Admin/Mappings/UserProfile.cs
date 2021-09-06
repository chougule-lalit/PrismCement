using BasonManagement.Infrastructure.Identity.Models;
using BasonManagement.Web.Areas.Admin.Models;
using AutoMapper;

namespace BasonManagement.Web.Areas.Admin.Mappings
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<ApplicationUser, UserViewModel>().ReverseMap();
        }
    }
}