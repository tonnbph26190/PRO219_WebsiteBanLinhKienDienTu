using System.ComponentModel.DataAnnotations;
using AppData.Models;

namespace PRO219_WebsiteBanDienThoai_FPhone.ViewModel
{
    public class ResetPasswordViewModel
    {
        [Display(Name = "Email")]
        public string Email { get; set; }

        public AccountEntity Data { get; set; } = new AccountEntity();
    }
}
