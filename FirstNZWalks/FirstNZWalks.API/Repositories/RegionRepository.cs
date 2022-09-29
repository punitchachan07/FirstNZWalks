using FirstNZWalks.API.Data;
using FirstNZWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace FirstNZWalks.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly IRegionRepository _regionRepository;
        private readonly NZWalksDbContext nZWalksDbContext;
        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public async Task<IEnumerable<Region>> GetAllAsync()
        {
            return await nZWalksDbContext.Regions.ToListAsync();
        }
    }
}
