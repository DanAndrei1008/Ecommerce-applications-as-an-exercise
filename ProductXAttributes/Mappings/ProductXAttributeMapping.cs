using AutoMapper;
using Internship.Business.ProductXAttributes.Commands.Create;
using Internship.Business.ProductXAttributes.Commands.Update;
using Internship.Business.ProductXAttributes.Queries.Filter;
using Internship.Controllers.ProductXAttributes.Models;
using Internship.Data;

namespace Internship.Controllers.ProductXAttributes.Mappings
{
    public class ProductXAttributeMapping:Profile
    {
        public ProductXAttributeMapping()
        {
            CreateMap<CreateProductXAttributeCommand, ProductXAttribute>();
            CreateMap<ProductXAttribute, CreateProductXAttributeResult>();
            CreateMap<CreateProductXAttributeRequest, CreateProductXAttributeCommand>();
            CreateMap<UpdateProductXAttributeCommand, ProductXAttribute>();
            CreateMap<ProductXAttribute, UpdateProductXAttributeResult>();
            CreateMap<ProductXAttribute, GetAllProductXAttributeResult>()
                        .ForMember(p => p.AttributeId, map => map.MapFrom(prop => prop.Attribute.Id))
                        .ForMember(p => p.ProductId, map => map.MapFrom(prop => prop.Product.Id));
            CreateMap<UpdateProductXAttributeRequest, UpdateProductXAttributeCommand>();
            CreateMap<ProductXAttribute, UpdateProductXAttributeCommand>()
                        .ForMember(p => p.AttributeId, map => map.MapFrom(prop => prop.Attribute.Id))
                        .ForMember(p => p.ProductId, map => map.MapFrom(prop => prop.Product.Id));

        }
    }
}
