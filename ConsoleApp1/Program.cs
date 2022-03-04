using Library.DataAccess;
using Library.DataAccess.Concrete;
using Library.Entities.Models;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            BookRepository repository = new BookRepository();
             Book book = new Book();
          //  book.Id = 1;
            book.CategoryId = 1;
            book.Description = "blah";
            book.PublisherId = 1;
            book.Name = "She";
             repository.Insert(book);

            //repository.Select();
            //repository.Delete(1);
           
            //Console.Write(repository.GetById(2));

          
        }
    }
}
