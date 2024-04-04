﻿using EShopper.DataAccessLayer.Abstract;
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
    public class EfPaymentRegisterDal : RepositoryDal<PaymentRegister>, IRepositoryDal<PaymentRegister>,IPaymentRegisterDal
    {
        private readonly EShopperDbContext _context;
        public EfPaymentRegisterDal(EShopperDbContext context) : base(context)
        {
            _context = context;
        }

        public bool UpdateStatus(int id)
        {
            var entity = _context.CouponCodes.Find(id);
            if (entity.Status) { entity.Status = false; } else { entity.Status = true; }
            _context.SaveChanges();
            return entity.Status;
        }
    }
}
