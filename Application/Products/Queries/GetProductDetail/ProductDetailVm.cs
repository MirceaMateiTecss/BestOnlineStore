using Application.Common.Mappings;
using AutoMapper;
using Domain.Entites;

namespace Application.Products.Queries.GetProductDetail
{
    public class ProductDetailVm : IMapFrom<Product>
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public decimal? UnitPrice { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDetailVm>()
                .ForMember(d => d.ProductId, opt => opt.MapFrom(s => s.ProductId))
                .ForMember(d => d.ProductName, opt => opt.MapFrom(s => s.ProductName))
                .ForMember(d => d.UnitPrice, opt => opt.MapFrom(s => s.UnitPrice));
        }
    }
}
