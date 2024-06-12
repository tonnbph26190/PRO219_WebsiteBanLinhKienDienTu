using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepositories
{
    public interface ICartDetailRepository
    {
        Task<CartDetailsEntity> Add(CartDetailsEntity obj);
        Task<CartDetailsEntity> Update(CartDetailsEntity obj);
        Task<List<CartDetailsEntity>> GetAll();
        Task Delete(Guid id);

        Task<CartDetailsEntity> GetById(Guid id);
        Task<List<CartDetailsEntity>> GetByIdAcout(Guid id);
    }
}
