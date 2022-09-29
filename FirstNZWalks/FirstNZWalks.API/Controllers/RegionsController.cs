using AutoMapper;
using FirstNZWalks.API.Models.Domain;
using FirstNZWalks.API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace FirstNZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;
        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllAsync();

            //var regionsDTO = new List<Models.DTO.Region>();

            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Models.DTO.Region()
            //    {
            //        Id = region.Id,
            //        Name = region.Name,
            //        Area =  region.Area,
            //        Population = region.Population,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Code = region.Code
            //    };
            //    regionsDTO.Add(regionDTO);
            //});
           var regionsDTO =  mapper.Map<List<Models.DTO.Region>>(regions);

            return Ok(regionsDTO);
        }
    }
}
