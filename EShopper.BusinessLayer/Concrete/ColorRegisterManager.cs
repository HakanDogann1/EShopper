using EShopper.BusinessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using EShopper.DtoLayer.Dtos.ColorRegisterDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Concrete
{
    public class ColorRegisterManager : GenericService<CreateColorResigterDto, UpdateColorRegisterDto, ResultColorRegisterDto, ColorRegister>, IColorRegisterService
    {
        public ColorRegisterManager(RepositoryDal<ColorRegister> repositoryDal) : base(repositoryDal)
        {
        }
    }
}
