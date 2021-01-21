using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LaundrySystem.UI.MappingProfiles
{
    public class DomainToResponseProfile : Profile
    {
        public DomainToResponseProfile()
        {
            //CreateMap<tblCompanyLocation, uspSelectCompanyLocation>();

            //CreateMap<tblProductCategory, uspSelectCategory>();
            //CreateMap<tblProductCategory, uspSelectProductCategory>();
            //CreateMap<tblProductCategory, uspSelectProductCategoryForMenu>();

            //CreateMap<Product, ProductToReturnDto>()
            //    .ForMember(d => d.ProductBrand, o => o.MapFrom(s => s.ProductBrand.Name))
            //    .ForMember(d => d.ProductType, o => o.MapFrom(s => s.ProductType.Name))
            //    .ForMember(d => d.PictureUrl, o => o.MapFrom<ProductUrlResolver>());
        }
    }
}
