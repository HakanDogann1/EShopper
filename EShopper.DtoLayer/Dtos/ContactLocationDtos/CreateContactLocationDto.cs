using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.ContactLocationDtos
{
    public class CreateContactLocationDto
    {
        public String Location { get; set; }
        public String PhoneNumber { get; set; }
        public String Email { get; set; }
        public bool Status { get; set; }
    }
}
