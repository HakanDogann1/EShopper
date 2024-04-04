using EShopper.SharedLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.SharedLayer
{
    public interface IResponse
    {
        public ReturnType ReturnType { get; set; }

        public String Message { get; set; }
    }
}
