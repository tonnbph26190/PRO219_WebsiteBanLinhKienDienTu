using AppData.ViewModels.Discount;
using AppData.ViewModels.DiscountNguoiDung;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IServices
{
    public interface IDiscountServices
    {
        Task<bool> AddVoucher(DiscountEntity discount);
        Task<bool> DeleteVoucher(Guid id);
        Task<bool> EditVoucher(DiscountEntity discount);
        Task<List<DiscountEntity>> GetallVoucher();
       List<DiscountEntity> GetallVoucher2();
      
    }
}
