using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppData.FPhoneDbContexts;
using AppData.IServices;
using AppData.Models;
using AppData.Utilities;
using AppData.ViewModels.Options;

namespace AppData.Services
{
    public class ContactService:IContactService
    {
        private FPhoneDbContext _context;

        public ContactService(FPhoneDbContext context)
        {
            _context = context;
        }
        public ContactEntity Add(ContactEntity obj)
        {
            try
            {
                _context.Contact.Add(obj);
                _context.SaveChanges();
            }
            catch (Exception e)
            {
               
            }

            return obj;
        }

        public ContactEntity Update(ContactEntity obj)
        {
            var data = new ContactEntity();
            try
            {
                data = _context.Contact.FirstOrDefault(c => c.ID == obj.ID);
               BeanUtils.CopyAllPropertySameName(obj,data);
                _context.Contact.Update(data);
                _context.SaveChanges();
            }
            catch (Exception e)
            {

            }

            return obj;
        }

        public List<ContactEntity> ListContact(ContactEntity SearchData, ListOptions listOptions)
        {
            var lst = new List<ContactEntity>();
            try
            {
                lst = _context.Contact.Where(c => (c.Status == null ||c.Status == SearchData.Status)).OrderByDescending(c =>c.CreateDate).Skip(listOptions.SkipCalc).Take(listOptions.PageSize).ToList();
                listOptions.AllRecordCount = _context.Contact.Count(c => (c.Status == null || c.Status == SearchData.Status));
            }
            catch (Exception e)
            {
                
            }

            return lst;
        }

        public ContactEntity Details(Guid id)
        {
            return _context.Contact.FirstOrDefault(c => c.ID == id);
        }
    }
}
