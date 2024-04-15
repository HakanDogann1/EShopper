using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.SizeRegisterDtos
{
    public class CreateSizeRegisterDto
    {
        public int ProductId { get; set; }
        public int Stock { get; set; }
        public bool Status { get; set; }
    }
}
