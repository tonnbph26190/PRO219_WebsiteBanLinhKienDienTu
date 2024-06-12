using AppData.Models;

namespace AppData.IRepositories
{
    public interface IProductionCompanyRepository
    {
        Task<ProductionCompanyEntity> Add(ProductionCompanyEntity obj);
        Task<ProductionCompanyEntity> Update(ProductionCompanyEntity obj);
        Task<List<ProductionCompanyEntity>> GetAll();
        Task Delete(Guid id);

        Task<ProductionCompanyEntity> GetById(Guid id);
    }
}
