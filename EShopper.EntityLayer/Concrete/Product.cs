using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.EntityLayer.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        public double Price { get; set; }
        public double LastPrice { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public int BrandId { get; set; }
        public Brand Brands { get; set; }

        public DateTime CreatedDate { get; set; }

        public bool Status { get; set; }

        public List<CouponCode> CouponCode { get; set; }

        public List<SizeRegister> SizeRegisters { get; set; }

        public List<ColorRegister> ColorRegisters { get; set; }
    }
}
