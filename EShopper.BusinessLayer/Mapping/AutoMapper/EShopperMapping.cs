using AutoMapper;
using EShopper.DtoLayer.Dtos.BrandDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Mapping.AutoMapper
{
    public class EShopperMapping:Profile
    {
        public EShopperMapping()
        {
            CreateMap<ResultBrandDto,Brand>().ReverseMap();
            CreateMap<UpdateBrandDto,Brand>().ReverseMap();
            CreateMap<CreateBrandDto,Brand>().ReverseMap();
        }
    }
}
