using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepositories
{
    public interface IRanksRepositories
    {
        Task<List<RankEntity>> GetAll();
    
        Task<RankEntity> GetById(Guid id);
        Task<List<RankEntity>> GetByYear(int days);
    }
}
