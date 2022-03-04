using Library.DataAccess.Abstract;
using Library.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class LikeRepository :ILikeRepository
    {
        protected ILibraryBase<Like> _likeRepository;
        public LikeRepository()
        {
            _likeRepository = new LibraryBase<Like>();
        }

        public async Task Delete(int id)
        {
           await _likeRepository.Delete(id);
        }

        public Task<List<Like>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Like> GetById(int id)
        {
            return _likeRepository.GetById(id);
        }

        public Task<Like> GetByName(Like entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Like entity)
        {
            return _likeRepository.Insert(entity);
        }

        public Task<IEnumerable<Like>> Select()
        {
            return _likeRepository.Select();
        }

        public Task<bool> Update(Like entity)
        {
           return _likeRepository.Update(entity);
        }

   
    }
}
