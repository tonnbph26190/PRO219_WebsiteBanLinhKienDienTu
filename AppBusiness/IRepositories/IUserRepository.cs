using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepositories
{
    public interface IUserRepository
    {
        public Task<List<AccountEntity>> GetAllAsync();
        public Task<AccountEntity?> GetById(Guid id);
    }
}
