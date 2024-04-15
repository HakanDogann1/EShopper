using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.ServiceDtos
{
    public class CreateServiceDto
    {
        public String Name { get; set; }
        public String Image { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
