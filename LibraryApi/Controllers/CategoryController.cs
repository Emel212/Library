using Library.DataAccess;
using Library.DataAccess.Abstract;
using Library.Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
       // private ICategoryRepository _categoryService;
        private ILibraryBase<Category> _categoryService;
        public CategoryController(ILibraryBase<Category> categoryRepository)
        {
            _categoryService = categoryRepository;
        }
        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            _categoryService.Delete(id);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id)

        {
            var result= await _categoryService.GetById(id);
            if (result != null)
                return Ok(result);
            return BadRequest("no record found");
        }
        [HttpPost]
        public async Task<bool> Insert(Category entity)
        {
            return await _categoryService.Insert(entity);
        }
      

        [HttpPut]
        public async Task<bool> Update(Category entity)
        {
            return await _categoryService.Update(entity);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await _categoryService.GetAll();
            if (result != null)
                return Ok(result);
            return BadRequest("no record found");
        }





    }
}
