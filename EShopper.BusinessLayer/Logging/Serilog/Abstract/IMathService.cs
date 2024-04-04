using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Logging.Serilog.Abstract
{
    public interface IMathService
    {
        decimal Divide(decimal paramterOne , decimal paramterTwo);
    }
}
