using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class BookRepo
    {
        private BookDAO bookDAO= new BookDAO();

        public IEnumerable<Book> GetListBook() => bookDAO.GetBookList();

        public void UpdateBook(Book book) => bookDAO.UpdateBook(book);

        public void AddBook(Book book) => bookDAO.AddBook(book);

        public void RemoveBook(Book book) => bookDAO.RemoveBook(book);

        public Book getBookByBookID(int bookID) => bookDAO.GetBookByID(bookID);

        public float GetMinPrice() => (float)GetListBook().Min(book => book.Price);
        public float GetMaxPrice() => (float)GetListBook().Max(book => book.Price);
    }
}
