using EShopper.BusinessLayer.Abstract;
using EShopper.DtoLayer.Dtos.ColorDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColorController : ControllerBase
    {
        private readonly IColorService _ColorService;
        private readonly ILogger<ColorController> _logger;

        public ColorController(IColorService ColorService, ILogger<ColorController> logger)
        {
            _ColorService = ColorService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> ColorList()
        {
            var value = await _ColorService.GetAllAsync();
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateColor(CreateColorDto createColorDto)
        {
            var value = await _ColorService.CreateAsync(createColorDto);
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _ColorService.GetByIdAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateColor(UpdateColorDto updateColorDto)
        {
            var value = _ColorService.Update(updateColorDto);
            return Ok(value);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> RemoveColor(int id)
        {

            var value = _ColorService.DeleteAsync(id);
            return Ok(value);
        }
    }
}
