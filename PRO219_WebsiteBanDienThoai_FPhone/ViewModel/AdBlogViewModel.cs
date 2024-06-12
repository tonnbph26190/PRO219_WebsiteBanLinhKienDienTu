using AppData.Models;
using AppData.ViewModels.Options;

namespace PRO219_WebsiteBanDienThoai_FPhone.ViewModel
{
    public class AdBlogViewModel
    {
        public List<BlogEntity> Records { get; set; } = new List<BlogEntity>();
        public ListOptions ListOptions { get; set; } = new ListOptions();
        public BlogEntity SearchData { get; set; } = new BlogEntity();
        public BlogEntity DetailModel { get; set; } = new BlogEntity();
    }
}
