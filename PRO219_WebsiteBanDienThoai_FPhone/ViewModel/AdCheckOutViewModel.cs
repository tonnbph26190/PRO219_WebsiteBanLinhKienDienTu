using AppData.Models;
using AppData.ViewModels.Phones;

namespace PRO219_WebsiteBanDienThoai_FPhone.ViewModel
{
    public class AdCheckOutViewModel
    {
        public List<VW_PhoneDetail> ListvVwPhoneDetails { get; set; } = new List<VW_PhoneDetail>();
        public List<ListImageEntity> listImage { get; set; } = new List<ListImageEntity>();
        public BillEntity Bill { get; set; } = new BillEntity();
        public List<BillDetailsEntity> ListBillDetail { get; set; } = new();
        public AccountEntity Account { get; set; } = new AccountEntity();
    }
}
