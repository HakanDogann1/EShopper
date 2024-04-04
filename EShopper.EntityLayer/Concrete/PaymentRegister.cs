using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.EntityLayer.Concrete
{
    public class PaymentRegister
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }

        public String NameSurname { get; set; }
        public String CardNumber { get; set; }
        public String Date {  get; set; }
        public String SecurtyNumber { get; set; }

        public bool Status { get; set; }
    }
}
