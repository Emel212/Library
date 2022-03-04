using Library.DataAccess.Abstract;
using Library.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class ImageRepository : IImagesRepository
    {
        protected ILibraryBase<Image> _imageRepository;
        public ImageRepository()
        {
            _imageRepository = new LibraryBase<Image>();
        }

        public async Task Delete(int id)
        {
            await _imageRepository.Delete(id);
        }

        public Task<List<Image>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Image> GetById(int id)
        {
            return _imageRepository.GetById(id);
        }

        public Task<Image> GetByName(Image entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Image entity)
        {
            return _imageRepository.Insert(entity);
        }

        public Task<IEnumerable<Image>> Select()
        {
            return _imageRepository.Select();
        }

        public Task<bool> Update(Image entity)
        {
            return _imageRepository.Update(entity);
        }

    }
}
