using EShopper.SharedLayer.Enums;
using EShopper.SharedLayer.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.SharedLayer
{
    public class Response<T> : IResponse<T>
    {

        public Response(ReturnType returnType, string message,T data)
        {
            Data = data;
            ReturnType = returnType;
            Message = message;
        }

        public Response(ErrorMessage error, ReturnType returnType, string message)
        {
            ReturnType = returnType;
            Message = message;
            Error = error;
        }

        public Response(List<ValidationError> validationError, ReturnType returnType, string message)
        {
            ValidationError = validationError;
            ReturnType = returnType;
            Message = message;
        }

        public ErrorMessage Error { get  ; set  ; }
        public List<ValidationError> ValidationError { get  ; set  ; }
        public ReturnType ReturnType { get  ; set  ; }
        public string Message { get  ; set  ; }
        public T Data { get; set; }


    }
}
