using EShopper.DtoLayer.Dtos.ColorRegisterDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Abstract
{
    public interface IColorRegisterService:IGenericService<CreateColorResigterDto,UpdateColorRegisterDto,ResultColorRegisterDto,ColorRegister>
    {
    }
}
