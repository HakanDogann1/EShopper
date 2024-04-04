using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.CategoryDtos
{
    public class ResultCategoryDto
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public int? ParentCategory { get; set; }
        public string Image { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
