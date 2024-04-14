using EShopper.BusinessLayer.Abstract;
using EShopper.DtoLayer.Dtos.BrandDtos;
using EShopper.DtoLayer.Dtos.CategoryDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ICategoryService categoryService, ILogger<CategoryController> logger)
        {
            _categoryService = categoryService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var value = await _categoryService.GetAllAsync();
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDto createCategoryDto)
        {
            var value = await _categoryService.CreateAsync(createCategoryDto);
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _categoryService.GetByIdAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateBrand(UpdateCategoryDto updateCategoryDto)
        {
            var value = _categoryService.Update(updateCategoryDto);
            return Ok(value);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> RemoveCategory(int id)
        {

            var value = _categoryService.DeleteAsync(id);
            return Ok(value);
        }
    }
}
