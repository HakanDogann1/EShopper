using EShopper.BusinessLayer.Abstract;
using EShopper.DtoLayer.Dtos.ContactDtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EShopper.APILayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _ContactService;
        private readonly ILogger<ContactController> _logger;

        public ContactController(IContactService ContactService, ILogger<ContactController> logger)
        {
            _ContactService = ContactService;
            _logger = logger;
        }
        [HttpGet]
        public async Task<IActionResult> ContactList()
        {
            var value = await _ContactService.GetAllAsync();
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactDto createContactDto)
        {
            var value = await _ContactService.CreateAsync(createContactDto);
            _logger.LogInformation("İlgili Kayıt Listelendi.");
            return Ok(value);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _ContactService.GetByIdAsync(id);
            return Ok(value);
        }
        [HttpPut]
        public IActionResult UpdateBrand(UpdateContactDto updateContactDto)
        {
            var value = _ContactService.Update(updateContactDto);
            return Ok(value);
        }
        [HttpDelete("id")]
        public async Task<IActionResult> RemoveContact(int id)
        {

            var value = _ContactService.DeleteAsync(id);
            return Ok(value);
        }
        }
}
