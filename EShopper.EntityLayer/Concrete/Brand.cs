﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.EntityLayer.Concrete
{
    public class Brand
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String Image { get; set; }

        public List<Product> Products { get; set; }
    }
}
