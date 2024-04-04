using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.EntityLayer.Concrete
{
    public class ColorRegister
    {
        public int Id { get; set; }

        [DeleteBehavior(DeleteBehavior.ClientNoAction)]
        [ForeignKey("ProductId")]
        public Product? Product { get; set; }

        public int ColorId { get; set; }
        public Color? Color { get; set; }

        public int Stock { get; set; }
    }
}
