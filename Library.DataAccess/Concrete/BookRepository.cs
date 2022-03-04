using Library.DataAccess.Abstract;
using Library.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class BookRepository :IBookRepository
    {
      
        protected ILibraryBase<Book> _bookRepository;
        protected IBookRepository _repository;
        
        public BookRepository(ILibraryBase<Book> bookRepository)
        {
            _bookRepository = bookRepository;
          
        }
        public async Task<IEnumerable<Book>> Select()
        {
            return await _bookRepository.Select();
        }

        public Task<bool> Insert(Book entity)
        {
            return  _bookRepository.Insert( entity);
        }

        public async Task Delete(int id)
        {
           await _bookRepository.Delete(id);
        }

       public Task<bool> Update(Book entity)
       {
            return  _bookRepository.Update(entity);
       }

        public Task<Book> GetById(int id)
        {   
              return _bookRepository.GetById(id);   
        }

        public  Task<List<Book>> GetAll() 
        {
            return _bookRepository.GetAll();
        }

        public async Task<List<Book>> GetByName(string name)
        {
                var matches=from book in Tools.Context.Books where book.Name.Contains(name.ToLower()) select book;
                return await matches.ToListAsync();
        }

        public async Task<List<Book>> GetByCategory(string name)
        {
            var matches = from category in Tools.Context.Books where category.Category.Name == name select category;
            return await matches.ToListAsync();
        }

        public async Task<List<Book>> GetByAuthor(string name)
        {
            var matches = from authors in Tools.Context.Books where authors.Author.Contains(name.ToLower()) select authors;
            return await matches.ToListAsync();
        }

     
    }
}
