using EShopper.BusinessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using EShopper.DtoLayer.Dtos.ColorDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Concrete
{
    public class ColorManager : GenericService<CreateColorDto, UpdateColorDto, ResultColorDto, Color>, IColorService
    {
        public ColorManager(RepositoryDal<Color> repositoryDal) : base(repositoryDal)
        {
        }
    }
}
