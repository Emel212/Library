using Library.DataAccess.Abstract;
using Library.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        protected ILibraryBase<Category> _categoryRepository;
        public CategoryRepository(ILibraryBase<Category> libraryFacade)
        {
            _categoryRepository = libraryFacade;
        }
        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }

        public async Task<List<Category>> GetAll()
        {
            var list =await _categoryRepository.GetAll();
            return list;
        }

        public Task<Category> GetById(int id)
        {
            return _categoryRepository.GetById(id);
        }

        public async Task<List<Category>> GetByName()
        {
            var list = await _categoryRepository.GetAll();
            return list;
        }

        public Task<bool> Insert(Category entity)
        {
            return _categoryRepository.Insert(entity);
        }

        public Task<IEnumerable<Category>> Select()
        {
            return _categoryRepository.Select();
        }

        public Task<bool> Update(Category entity)
        {
            return _categoryRepository.Update(entity);
        }

        Task ILibraryBase<Category>.Delete(int id)
        {
            return _categoryRepository.Delete(id);
        }

   
      
    }
}
