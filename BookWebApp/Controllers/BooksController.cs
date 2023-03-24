using BookLibrary.DataAccess;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BookWebApp.Controllers
{
    public class BooksController : Controller
    {
        BookRepo bookRepo = null;
        public BooksController() => bookRepo = new BookRepo();
        CategoryRepo categoryRepo = new CategoryRepo();
        // GET: BooksController

        public ActionResult List(string? bookName, int? categoryId)
        {
            var username = HttpContext.Session.GetString("username");
            Account a = new AccountRepo().CheckAuthentication(username);
            var books = bookRepo.GetListBook();
            if (!bookName.IsNullOrEmpty())
                books = books.Where(b => b.BookName.Contains(bookName));
            if (categoryId.HasValue)
                books = books.Where(b => b.CategoryId == categoryId);
            var listCategory = categoryRepo.GetListCategory();

            ViewBag.Categories = listCategory;
            ViewBag.ListBook = books;
            return View(a);
        }

        // GET: BooksController/Details/5
        public ActionResult Details(int id)
        {
            var username = HttpContext.Session.GetString("username");
            Account a = new AccountRepo().GetListAccount().SingleOrDefault(a => a.Username == username);
            var book = bookRepo.getBookByBookID(id);
            ViewBag.book = book;
            var cate = new CategoryRepo().GetListCategory();
            return View(a);
        }

        // GET: BooksController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BooksController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    bookRepo.AddBook(book);
                }
                TempData["Add"] = "Add new book successfully";
                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(book);
            }
        }

        // GET: BooksController/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
                return NotFound();
            var book = bookRepo.getBookByBookID(id.Value);
            if (book == null)
                return NotFound();
            return View(book);
        }

        // POST: BooksController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Book book)
        {
            try
            {
                if (ModelState.IsValid)
                    bookRepo.UpdateBook(book);
                ViewBag.Update = "Update successfully";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        // GET: BooksController/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
                return NotFound();
            var book = bookRepo.getBookByBookID(id.Value);
            if (book == null)
                return NotFound();
            return View(book);
        }

        // POST: BooksController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            var book = bookRepo.getBookByBookID(id);
            try
            {
                bookRepo.RemoveBook(book);
               TempData["Delete"] = "Delete Successfully";
                return RedirectToAction(nameof(List));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

    }
}
