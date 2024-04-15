using EShopper.BusinessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using EShopper.DtoLayer.Dtos.ContactLocationDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Concrete
{
    public class ContactLocationManager : GenericService<CreateContactLocationDto, UpdateContactLocationDto, ResultContactLocationDto, ContactLocation>, IContactLocationService
    {
        public ContactLocationManager(RepositoryDal<ContactLocation> repositoryDal) : base(repositoryDal)
        {
        }
    }
}
