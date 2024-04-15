using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.SubscribeDtos
{
    public class UpdateSubscribeDto
    {
        public int Id { get; set; }
        public String Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
