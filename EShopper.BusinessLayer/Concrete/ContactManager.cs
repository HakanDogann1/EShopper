using EShopper.BusinessLayer.Abstract;
using EShopper.DataAccessLayer.Concrete;
using EShopper.DtoLayer.Dtos.ContactDtos;
using EShopper.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.BusinessLayer.Concrete
{
    public class ContactManager : GenericService<CreateContactDto, UpdateContactDto, ResultContactDto, Contact>, IContactService
    {
        public ContactManager(RepositoryDal<Contact> repositoryDal) : base(repositoryDal)
        {
        }
    }
}
