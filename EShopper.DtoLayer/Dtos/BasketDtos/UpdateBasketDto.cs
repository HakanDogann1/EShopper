using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DtoLayer.Dtos.BasketDtos
{
    public class UpdateBasketDto
    {
        public int Id { get; set; }
        public int AppUserId { get; set; }
        public int ProductId { get; set; }
        public int Piece { get; set; }
        public double Price { get; set; }
        public bool PaymentStatus { get; set; }
    }
}
