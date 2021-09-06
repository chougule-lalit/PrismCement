using BasonManagement.Application.Features.Brands.Commands.Create;
using BasonManagement.Application.Features.Brands.Commands.Update;
using BasonManagement.Application.Features.Brands.Queries.GetAllCached;
using BasonManagement.Application.Features.Brands.Queries.GetById;
using BasonManagement.Web.Areas.Catalog.Models;
using AutoMapper;

namespace BasonManagement.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}