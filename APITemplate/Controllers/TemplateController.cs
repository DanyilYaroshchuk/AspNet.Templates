using API.Template.BLL.Interfaces;
using API.Template.BLL.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace APITemplate.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TemplateController : ControllerBase
    {
        private readonly ITemplateService _templateEntityService;

        public TemplateController(ITemplateService templateEntityService)
        {
            _templateEntityService = templateEntityService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var entities = await _templateEntityService.GetAllAsync();
            return Ok(entities);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var entity = await _templateEntityService.GetByIdAsync(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] TemplateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _templateEntityService.AddAsync(dto);
            return CreatedAtAction(nameof(GetById), new { id = dto.Id }, dto);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] TemplateDto dto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _templateEntityService.UpdateAsync(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            await _templateEntityService.DeleteAsync(id);
            return Ok();
        }
    }
}
