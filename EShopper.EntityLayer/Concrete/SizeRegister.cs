using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.EntityLayer.Concrete
{
    public class SizeRegister
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; }

        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        [ForeignKey("SizeId")]
        public Size Size { get; set; }

        public int Stock { get; set; }

        public bool Status { get; set; }
    }
}
