﻿using EShopper.DtoLayer.Dtos.ContactLocationDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Abstract
{
    public interface IContactLocationService:IGenericService<CreateContactLocationDto,UpdateContactLocationDto,ResultContactLocationDto,ContactLocation>
    {
    }
}
