using Library.DataAccess;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete;
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
    public class LibraryController : ControllerBase
    {
        private ILibraryBase<Book> _bookService;
        private IBookRepository _repository;
       
        public LibraryController(ILibraryBase<Book> bookService,IBookRepository repository)
        {
            _bookService = bookService;
            _repository = repository;
           
        }


        [HttpDelete("{id:int}")]
        public void Delete(int id)
        {
            _bookService.Delete(id);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById(int id) 
        {
             var result=await _bookService.GetById(id);

            if (result != null)
                return Ok(result);
            return BadRequest("no record found");
        }
        [HttpPost]
        public async Task<bool> Insert([FromBody]Book entity)
        {
            return await _bookService.Insert(entity);
        }
        /*public async Task<IEnumerable<Book>> Select()
        {
            var book = await _bookService.Select();
            return Ok(book);
        }*/
        /* [HttpGet]
         public async Task<IActionResult> Select()
         {
             return (IActionResult)await _bookService.Select();  
         }*/

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]Book entity)
        {
            var result= await _bookService.Update(entity);
            return Ok(result);
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var list = await _bookService.GetAll();
            return Ok(list);
        }

       [HttpGet]
       [ActionName("BookByName")]
        public async Task<IActionResult> GetByName(string name)
        {
            var result = await _repository.GetByName(name);
            bool isEmpty = !result.Any();
            if(isEmpty==false)
            return Ok(result);
            return BadRequest("no record found");

        }

        [HttpGet]
        [ActionName("BookByCategory")]
        public async Task<IActionResult> GetByCategory(string name)
        {
            var list = await _repository.GetByCategory(name);
            bool isEmpty = !list.Any();
            if (isEmpty == false)
                return Ok(list);
            return BadRequest("no record found");
        }
        [HttpGet]
        [ActionName("BookByAuthor")]
        public async  Task<IActionResult> GetByAuthor(string name)
        {
            var list =await  _repository.GetByAuthor(name);
            bool isEmpty = !list.Any();
            if (isEmpty == false)
                return Ok(list);
            return BadRequest("no record found");
        }

    }
}
