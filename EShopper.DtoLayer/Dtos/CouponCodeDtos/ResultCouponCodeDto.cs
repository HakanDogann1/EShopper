using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.CouponCodeDtos
{
    public class ResultCouponCodeDto
    {
        public int Id { get; set; }
        public String Code { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime EndDate { get; set; }

        public bool Status { get; set; }

        public int ProductId { get; set; }
    }
}
