using spaAppClassLib.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spaAppClassLib.Services
{
    interface IBookService
    {
        public List<Book> GetAllBooks() {
            throw new NotImplementedException();
        }
        public BookService GetBook(int bookId);
        public void AddBook(Book book);
        public void DeleteBook(int bookId);
        
    }
}
