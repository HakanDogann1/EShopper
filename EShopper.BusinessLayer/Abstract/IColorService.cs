using EShopper.DtoLayer.Dtos.ColorDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Abstract
{
    public interface IColorService:IGenericService<CreateColorDto,UpdateColorDto,ResultColorDto,Color>
    {
    }
}
