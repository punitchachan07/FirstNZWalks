using FirstNZWalks.API.Models.Domain;

namespace FirstNZWalks.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
