using FirstNZWalks.API.Models.Domain;

namespace FirstNZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
        Task<Region> GetAll(Guid id);

        Task<Region> AddAsync(Region region);
        Task<Region> DeleteAsync(Guid id);
        Task<Region> UpdateAsync(Guid id, Region region);
    }
}
