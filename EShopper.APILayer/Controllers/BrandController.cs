using EShopper.BusinessLayer.Abstract;
using EShopper.DtoLayer.Dtos.BrandDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IBrandService _brandService;
        private readonly ILogger<BrandController> _logger;

        public BrandController(IBrandService brandService, ILogger<BrandController> logger)
        {
            _brandService = brandService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> BrandList()
        {
            var value = await _brandService.GetAllAsync();
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandDto createBrandDto)
        {
            var value = await _brandService.CreateAsync(createBrandDto);
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _brandService.GetByIdAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateBrand(UpdateBrandDto updateBrandDto)
        {
            var value = _brandService.Update(updateBrandDto);
            return Ok(value);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> RemoveBrand(int id)
        {
            
            var value = _brandService.DeleteAsync(id);
            return Ok(value);
        }
    }
}
