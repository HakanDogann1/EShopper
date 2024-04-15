using EShopper.DtoLayer.Dtos.ContactDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Abstract
{
    public interface IContactService:IGenericService<CreateContactDto,UpdateContactDto,ResultContactDto,Contact>
    {
    }
}
