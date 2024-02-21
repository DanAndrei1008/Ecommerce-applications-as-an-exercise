using AutoMapper;
using Internship.Business.ProductXSuppliers.Commands.Create;
using Internship.Business.ProductXSuppliers.Commands.Delete;
using Internship.Business.ProductXSuppliers.Commands.Update;
using Internship.Business.ProductXSuppliers.Queries.GetBySupplieId;
using Internship.Controllers.ProductXSuppliers.Models;
using Internship.Data;

namespace Internship.Controllers.ProductXSuppliers.Mappings
{
    public class ProductXSupplierMapping: Profile
    {
        public ProductXSupplierMapping()
        {
            CreateMap<PostPsRequest, PostPsCommand>();
            CreateMap<PostPsCommand, ProductXSupplier>();

            CreateMap<ProductXSupplier, PostPsResult>();//.ForMember(x => x.ProductId, map => map.MapFrom(x => x.Product.Id));
           // CreateMap<ProductXSupplier, PostPsResult>();//.ForMember(x => x.SupplierId, map => map.MapFrom(x => x.Supplier.Id));

            CreateMap<ProductXSupplier, GetAllPsResult>();//.ForMember(x => x.ProductId, map => map.MapFrom(x => x.Product.Id));
            //CreateMap<ProductXSupplier, GetAllPsResult>();//.ForMember(x => x.SupplierId, map => map.MapFrom(x => x.Supplier.Id));

            CreateMap<DeletePsRequest, DeletePsCommand>();

            CreateMap<ProductXSupplier, DeletePsResult>();//.ForMember(x => x.ProductId, map => map.MapFrom(x => x.Product.Id));
            //CreateMap<ProductXSupplier, DeletePsResult>();//.ForMember(x => x.SupplierId, map => map.MapFrom(x => x.Supplier.Id));

            CreateMap<UpdatePsRequest, UpdatePsCommand>();

            CreateMap<ProductXSupplier, UpdatePsResult>();//.ForMember(x => x.ProductId, map => map.MapFrom(x => x.Product.Id));
            //CreateMap<ProductXSupplier, UpdatePsResult>();//.ForMember(x => x.SupplierId, map => map.MapFrom(x => x.Supplier.Id));

            CreateMap<GetBySupplierIdRequest, GetBySupplierIdQuery>();

            CreateMap<ProductXSupplier, GetBySupplierIdResult>();//.ForMember(x => x.ProductId, map => map.MapFrom(x => x.Product.Id));
            //CreateMap<ProductXSupplier, GetBySupplierIdResult>();//.ForMember(x => x.SupplierId, map => map.MapFrom(x => x.Supplier.Id));

        }
    }
}
