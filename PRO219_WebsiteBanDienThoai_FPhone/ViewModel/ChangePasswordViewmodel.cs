using AppData.Models;

namespace PRO219_WebsiteBanDienThoai_FPhone.ViewModel
{
    public class ChangePasswordViewmodel
    {
        public AccountEntity Data { get; set; } = new AccountEntity();
        public string Captcha { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string CfPassword { get; set; }
    }
}
