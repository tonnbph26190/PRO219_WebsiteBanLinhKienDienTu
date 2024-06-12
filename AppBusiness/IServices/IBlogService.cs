using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppData.Models;
using AppData.ViewModels.Options;

namespace AppData.IServices
{
    public interface IBlogService
    {
        public BlogEntity Add(BlogEntity obj);
        public BlogEntity Update(BlogEntity obj);
        public BlogEntity Delete(Guid id);
        public BlogEntity Details(Guid id);   
        public List<BlogEntity> GetAll(BlogEntity searchData,ListOptions listOptions);
            
    }
}
