using EShopper.BusinessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using EShopper.DtoLayer.Dtos.BrandDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Concrete
{
    public class BrandManager : GenericService<CreateBrandDto, UpdateBrandDto, ResultBrandDto, Brand>, IGenericService<CreateBrandDto, UpdateBrandDto, ResultBrandDto, Brand>,IBrandService
    {
        public BrandManager(RepositoryDal<Brand> repositoryDal) : base(repositoryDal)
        {
        }
    }
}
