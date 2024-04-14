using EShopper.BusinessLayer.Abstract;
using EShopper.DtoLayer.Dtos.ColorRegisterDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorRegisterController : ControllerBase
    {
        private readonly IColorRegisterService _ColorRegisterService;
        private readonly ILogger<ColorRegisterController> _logger;

        public ColorRegisterController(IColorRegisterService ColorRegisterService, ILogger<ColorRegisterController> logger)
        {
            _ColorRegisterService = ColorRegisterService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> ColorRegisterList()
        {
            var value = await _ColorRegisterService.GetAllAsync();
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateColorRegister(CreateColorResigterDto createColorRegisterDto)
        {
            var value = await _ColorRegisterService.CreateAsync(createColorRegisterDto);
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _ColorRegisterService.GetByIdAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateBrand(UpdateColorRegisterDto updateColorRegisterDto)
        {
            var value = _ColorRegisterService.Update(updateColorRegisterDto);
            return Ok(value);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> RemoveColorRegister(int id)
        {

            var value = _ColorRegisterService.DeleteAsync(id);
            return Ok(value);
        }
    }
}
