using EShopper.DataAccessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using EShopper.DataAccessLayer.Context;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DataAccessLayer.EntityFramework
{
    public class EfColorDal : RepositoryDal<Color>, IRepositoryDal<Color>,IColorDal
    {
        public EfColorDal(EShopperDbContext context) : base(context)
        {
        }
    }
}
