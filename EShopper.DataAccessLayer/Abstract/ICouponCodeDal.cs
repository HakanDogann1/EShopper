using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DataAccessLayer.Abstract
{
    public interface ICouponCodeDal
    {
        public bool UpdateStatus(int id);
    }
}
