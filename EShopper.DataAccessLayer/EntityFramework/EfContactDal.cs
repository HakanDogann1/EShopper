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
    public class EfContactDal : RepositoryDal<Contact>, IRepositoryDal<Contact>,IContactDal
    {
        private readonly EShopperDbContext _context;
        public EfContactDal(EShopperDbContext context) : base(context)
        {
            _context = context;
        }

        public bool Read(int id)
        {
            var entity = _context.Contacts.Find(id);
            entity.Read = true;
            _context.SaveChanges();
            return true;
        }
    }
}
