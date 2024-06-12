using AppData.Models;
using AppData.ViewModels;
using AppData.ViewModels.Phones;

namespace AppData.IServices
{
    public interface IListImageService
    {
        List<ListImageEntity> GetListImagesByIdPhoneDetail(Guid IdPhoneDetail);
        ListImageEntity Create(ListImageEntity model, out DataError error);
        bool Delete(Guid Id);
        int CheckExits(string imageUrl,Guid idPhoneDetail);
        string GetFirstImageByIdPhondDetail(Guid id);
        List<VW_List_By_IdPhone> GetListImageByIdPhone(Guid idPhone);
    }   
}
