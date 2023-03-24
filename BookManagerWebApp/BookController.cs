using BookLibrary.DataAccess;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookManagerWebApp
{
    public class BookController : Controller
    {
        BookRepo bookRepo = null;
        public BookController() => bookRepo= new BookRepo();
        // GET: BookController
        public ActionResult Index()
        {
            var bookList = bookRepo.GetListBook();
            return View(bookList);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
                return NotFound();
            var book = bookRepo.getBookByBookID(id.Value);
            if(book == null)
                return NotFound();
            return View(book);
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    bookRepo.AddBook(book);
                }
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(book);
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int? id)
        {
            if(id == null)
                return NotFound();
            var book = bookRepo.getBookByBookID(id.Value);
            if(book == null)
                return NotFound();
            return View(book);
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Book book)
        {
            try
            {
                if( id != book.BookId)
                {
                    return NotFound();
                }
                if(ModelState.IsValid)
                    bookRepo.UpdateBook(book);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int? id)
        {
            if(id == null)
                return NotFound();
            var book = bookRepo.getBookByBookID(id.Value);
            if(book == null)
                return NotFound();
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var book = bookRepo.getBookByBookID(id);
            try
            {
                bookRepo.RemoveBook(book);
                return RedirectToAction(nameof(Index));
            }
            catch(Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
