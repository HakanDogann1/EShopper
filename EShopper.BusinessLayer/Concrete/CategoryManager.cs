using EShopper.BusinessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using EShopper.DtoLayer.Dtos.CategoryDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Concrete
{
    public class CategoryManager :  GenericService<CreateCategoryDto, UpdateCategoryDto, ResultCategoryDto, Category>, ICategoryService
    {
        public CategoryManager(RepositoryDal<Category> repositoryDal) : base(repositoryDal)
        {
        }
    }
}
