using EShopper.DtoLayer.Dtos.CategoryDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Abstract
{
    public interface ICategoryService:IGenericService<CreateCategoryDto,UpdateCategoryDto,ResultCategoryDto,Category>
    {
    }
}
