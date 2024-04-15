using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.ProductDtos
{
    public class CreateProductDto
    {
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public double LastPrice { get; set; }
        public int CategoryId { get; set; }

        public int BrandId { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }
    }
}
