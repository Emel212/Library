using Library.Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public  class LibraryBase<T> : ILibraryBase<T> where T : class

    {
      
        //protected DbContext _context;
        private DbSet<T> _dbset;
       
       
        public LibraryBase() 
        {
          
            _dbset = Tools.Context.Set<T>();
        }
      
        public async Task<List<T>> GetAll()
        {
            return await _dbset.ToListAsync<T>();
        }
       
        public async Task<T> GetById(int id)
        {
        
            var list=await Tools.Context.FindAsync<T>(id);
            return list;
        }
        public async Task<bool> Insert(T entity)
        {
            Tools.Context.Add<T>(entity);
            return await Tools.Exec(Tools.Context);
        }


        public async Task<bool> Update(T entity)
        {
            throw new NotImplementedException();
            //Tools.Context.Entry<T>(entity).State =EntityState.Modified;
            //Tools.Context.SaveChanges();
            //Tools.Context.Update<T>(entity);
            //return await Tools.Exec(Tools.Context);
   
        }

        async Task ILibraryBase<T>.Delete(int id)
        {
             var findId =await GetById(id);
             Tools.Context.Remove<T>(findId);
             await Tools.Context.SaveChangesAsync();
        }

         async Task<IEnumerable<T>> ILibraryBase<T>.Select()
         {
          
            return await _dbset.ToListAsync();
         }
    }
}
