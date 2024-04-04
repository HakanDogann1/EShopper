using AutoMapper;
using EShopper.BusinessLayer.Mapping.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Mapping
{
    public class ObjectMapping
    {
        public static Lazy<IMapper> lazy => new Lazy<IMapper>(() =>
        {
            var config = new MapperConfiguration(opt =>
            {
                opt.AddProfile(new EShopperMapping());
            });
            return config.CreateMapper();
        });

        public static IMapper mapper => lazy.Value;

    }
}
