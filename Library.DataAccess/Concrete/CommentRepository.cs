using Library.DataAccess.Abstract;
using Library.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class CommentRepository : ICommentRepository
    {
        protected ILibraryBase<Comment> _commentRepository;
        public CommentRepository()
        {
            _commentRepository = new LibraryBase<Comment>();
        }

        public async Task Delete(int id)
        {
           await _commentRepository.Delete(id);
        }

        public Task<List<Comment>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetById(int id)
        {
            return _commentRepository.GetById(id);
        }

        public Task<Comment> GetByName(Comment entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Comment entity)
        {
            return _commentRepository.Insert(entity);
        }

        public Task<IEnumerable<Comment>> Select()
        {
            return _commentRepository.Select();
        }

        public Task<bool> Update(Comment entity)
        {
            return _commentRepository.Update(entity);
        }

     
    }
}
