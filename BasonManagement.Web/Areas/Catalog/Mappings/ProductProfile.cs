using BasonManagement.Application.Features.Products.Commands.Create;
using BasonManagement.Application.Features.Products.Commands.Update;
using BasonManagement.Application.Features.Products.Queries.GetAllCached;
using BasonManagement.Application.Features.Products.Queries.GetById;
using BasonManagement.Web.Areas.Catalog.Models;
using AutoMapper;

namespace BasonManagement.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}