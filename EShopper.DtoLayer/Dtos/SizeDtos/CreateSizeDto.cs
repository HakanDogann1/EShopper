using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.SizeDtos
{
    public class CreateSizeDto
    {
        public double Name { get; set; }

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
    }
}
