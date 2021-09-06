using BasonManagement.Application.Features.Products.Commands.Create;
using BasonManagement.Application.Features.Products.Queries.GetAllCached;
using BasonManagement.Application.Features.Products.Queries.GetAllPaged;
using BasonManagement.Application.Features.Products.Queries.GetById;
using BasonManagement.Domain.Entities.Catalog;
using AutoMapper;

namespace BasonManagement.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}