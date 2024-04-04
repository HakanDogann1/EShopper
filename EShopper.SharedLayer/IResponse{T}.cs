using EShopper.SharedLayer.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.SharedLayer
{
    public interface IResponse<T> :IResponse
    {
        public T Data { get; set; }
        public ErrorMessage Error { get; set; }
        public List<ValidationError> ValidationError { get; set; }
    }
}
