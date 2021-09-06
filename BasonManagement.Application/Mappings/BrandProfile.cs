using BasonManagement.Application.Features.Brands.Commands.Create;
using BasonManagement.Application.Features.Brands.Queries.GetAllCached;
using BasonManagement.Application.Features.Brands.Queries.GetById;
using BasonManagement.Domain.Entities.Catalog;
using AutoMapper;

namespace BasonManagement.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}