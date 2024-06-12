using AppData.Models;
using AppData.ViewModels;
using AppData.ViewModels.Options;

namespace AppData.IServices
{
    public interface IAccountService
    {
        public List<ApplicationUser> GetAllAsync(ApplicationUser Search, ListOptions options);
        public ApplicationUser GetById(string id);
        public ApplicationUser GetByUserName(string userName);
        public ApplicationUser Update(string id, ApplicationUser user,out DataError error);
        public AccountEntity UpdateUser(Guid id, AccountEntity user, out DataError error);
        public AccountEntity GetUserByEmail(string email);
        public AccountEntity GetUserByUserName(string userName);
        public AccountEntity GetUserById(Guid idGuid);
        public AccountEntity GetUserByPhoneNumber(string phoneNumber);
        public AccountEntity CreateAccountForUser(AccountEntity model); 
    }       
}
