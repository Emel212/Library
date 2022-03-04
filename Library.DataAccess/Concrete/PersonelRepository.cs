using Library.DataAccess.Abstract;
using Library.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess.Concrete
{
    public class PersonelRepository : IPersonelRepository
    {
        protected ILibraryBase<Personel> _personelRepository;
        public PersonelRepository()
        {
            _personelRepository =new LibraryBase<Personel>();
        }

        public async Task Delete(int id)
        {
            await _personelRepository.Delete(id);
        }

        public Task<List<Personel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Personel> GetById(int id)
        {
          return  _personelRepository.GetById(id);
        }

        public Task<Personel> GetByName(Personel entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Insert(Personel entity)
        {
            return _personelRepository.Insert(entity);

        }

        public Task<IEnumerable<Personel>> Select()
        {
           return _personelRepository.Select();
        }

        public Task<bool> Update(Personel entity)
        {
            return _personelRepository.Update(entity);
        }

    
    }
}
