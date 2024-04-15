using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.ContactDtos
{
    public class CreateContactDto
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String Subject { get; set; }
        public String Message { get; set; }
        public bool Read { get; set; }
    }
}
