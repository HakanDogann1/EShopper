using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DataAccessLayer.Abstract
{
    public interface ISizeRegisterDal
    {
        public bool UpdateStatus(int id);
    }
}
