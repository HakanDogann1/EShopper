using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.EntityLayer.Concrete
{
    public class Category
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int? ParentCategory { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<Product> Products { get; set; }
        public List<Size> Sizes { get; set; }
        public List<Color> Colors { get; set; }
    }
}
