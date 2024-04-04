using EShopper.DtoLayer.Dtos.BrandDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Abstract
{
    public interface IBrandService:IGenericService<CreateBrandDto,UpdateBrandDto,ResultBrandDto,Brand>
    {
    }
}
