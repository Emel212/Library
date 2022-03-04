using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public interface ILibraryBase<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<IEnumerable<T>> Select();
        public Task<bool> Insert(T entity);
        Task Delete(int id);
        Task<bool> Update(T entity);
        Task<T> GetById(int id);
       
        
    }
}
