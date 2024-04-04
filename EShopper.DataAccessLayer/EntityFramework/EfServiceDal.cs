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
    public class EfServiceDal : RepositoryDal<Service>, IRepositoryDal<Service>,IServiceDal
    {
        public EfServiceDal(EShopperDbContext context) : base(context)
        {
        }
    }
}
