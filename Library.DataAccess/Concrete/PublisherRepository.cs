using Library.DataAccess.Abstract;
using Library.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class PublisherRepository : IPublisherRepository
    {
        ILibraryBase<Publisher> _publisherRepository;
        public PublisherRepository()
        {
            _publisherRepository = new LibraryBase<Publisher>();
        }

        public async Task Delete(int id)
        {
            await _publisherRepository.Delete(id);
        }

        public Task<List<Publisher>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> GetById(int id)
        {
            return _publisherRepository.GetById(id);
        }

        public Task<Publisher> GetByName(Publisher entity)
        {
            throw new NotImplementedException();
        }

        public Task<Publisher> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Publisher entity)
        {
            return _publisherRepository.Insert(entity);
        }

        public Task<IEnumerable<Publisher>> Select()
        {
            return _publisherRepository.Select();
        }

        public Task<bool> Update(Publisher entity)
        {
            return _publisherRepository.Update(entity);
        }

      
    }
}
