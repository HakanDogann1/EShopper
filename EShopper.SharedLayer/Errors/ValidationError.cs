using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.SharedLayer.Errors
{
    public class ValidationError
    {
        public String PropertyName { get; set; }
        public String Message { get; set; }
        public int StatusCode { get; set; }
    }
}
