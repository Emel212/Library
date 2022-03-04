using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Library.Entities.Models;


namespace Library.DataAccess.Abstract
{
    public interface IBookRepository:ILibraryBase<Book>
    {

        Task<List<Book>> GetByName(string name);
        Task<List<Book>> GetByCategory(string name);
        Task<List<Book>> GetByAuthor(string name);
    }
}
