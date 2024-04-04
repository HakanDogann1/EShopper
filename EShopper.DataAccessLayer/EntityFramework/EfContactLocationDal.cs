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
    public class EfContactLocationDal : RepositoryDal<ContactLocation>, IRepositoryDal<ContactLocation>,IContactLocationDal
    {
        private readonly EShopperDbContext _context;
        public EfContactLocationDal(EShopperDbContext context) : base(context)
        {
            _context = context;
        }

        public bool UpdateStatus(int id)
        {
            var entity = _context.ContactLocations.Find(id);
            bool value = entity.Status ? false : true;
            entity.Status = value;
            _context.SaveChanges();
            return value;
        }
    }
}
