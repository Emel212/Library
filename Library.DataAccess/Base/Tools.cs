using Library.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.DataAccess
{
    public class Tools

    {
       
        private static LibraryContext context;
        public static LibraryContext Context
        {
            get
            {
                    context = new LibraryContext();
                    return  context;
            }
          
        }

        public static async Task<bool> Exec(LibraryContext cmd)
        {
            try
            {
               Task<int> effected = cmd.SaveChangesAsync();
                return await effected > 0 ? true : false;
            }
            catch (Exception z)
            {
                return false;
            }
           
        }
    }
}
