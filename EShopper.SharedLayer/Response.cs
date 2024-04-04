using EShopper.SharedLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.SharedLayer
{
    public class Response : IResponse
    {
        public ReturnType ReturnType { get; set; }
        public string Message { get; set; }

        public Response(ReturnType returnType)
        {
            ReturnType = returnType;
        }
        public Response(ReturnType returnType, string message)
        {
            ReturnType = returnType;
            Message = message;
        }
    }
}
