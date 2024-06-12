using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepositories
{
    public interface IcartRepository
    {
        Task<CartEntity> Add(CartEntity obj);
        Task<CartEntity> GetById(Guid id);
        Task<List<CartEntity>> GetAll();
        Task Delete(Guid id);

      
    }
}
