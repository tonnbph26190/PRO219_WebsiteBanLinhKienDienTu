using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppData.Models;
using AppData.ViewModels.Options;

namespace AppData.IServices
{
    public interface IContactService
    {
        public ContactEntity Add(ContactEntity obj);
        public ContactEntity Update(ContactEntity obj);
        public List<ContactEntity> ListContact(ContactEntity SearchData,ListOptions listOptions);
        public ContactEntity Details(Guid id);
    }
}
