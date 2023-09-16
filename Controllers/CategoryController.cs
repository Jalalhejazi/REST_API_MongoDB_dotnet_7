using Microsoft.AspNetCore.Mvc;
using MongoDotnetDemo.Models;
using MongoDotnetDemo.Services;

namespace MongoDotnetDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Category : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        public Category(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        // GET: api/Category
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var categories = await _categoryService.GetAllAsyc();
            return Ok(categories);
        }

        // GET api/Category/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            var category = await _categoryService.GetById(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        // POST api/Category
        [HttpPost]
        public async Task<IActionResult> Post(Category category)
        {
           await _categoryService.CreateAsync(category);
            return Ok("created successfully");
        }

        // PUT api/Category/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(string id, [FromBody] Category newCategory)
        {
            var category = await _categoryService.GetById(id);
            if (category == null)
                return NotFound();
            await _categoryService.UpdateAsync(id, newCategory);
            return Ok("updated successfully");
        }

        // DELETE api/Category/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var category = await _categoryService.GetById(id);
            if (category == null)
                return NotFound();
            await _categoryService.DeleteAysnc(id);
            return Ok("deleted successfully");
        }
    }
}
