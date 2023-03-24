using BookLibrary.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class BookDAO
    {
        public IEnumerable<Book> GetBookList()
        {
            var books = new List<Book>();
            try
            {
                using var context = new ProjectBookContext();
                books = context.Books.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return books;
        }

        public Book GetBookByID(int id)
        {
            Book book = null;
            try
            {
                using var context = new ProjectBookContext();
                book = context.Books.FirstOrDefault(c => c.BookId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return book;
        }

        public void AddBook(Book book)
        {
            try
            {
                Book _book = GetBookByID(book.BookId);
                if (_book == null)
                {
                    using var context = new ProjectBookContext();
                    context.Books.Add(book);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The book is already exits");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateBook(Book book)
        {
            try
            {
                Book _book = GetBookByID(book.BookId);
                if (_book != null)
                {
                    using var context = new ProjectBookContext();
                    context.Books.Update(book);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The book does not already exits");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveBook(Book book)
        {
            try
            {
                    using var context = new ProjectBookContext();
                    context.Books.Remove(book);
                    context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        
    }
}