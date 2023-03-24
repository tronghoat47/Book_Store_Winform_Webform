using BookLibrary.DataAccess;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApp.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        AccountRepo AccountRepo = new AccountRepo();
        public IActionResult Edit(int id) {

            return View(AccountRepo.GetListAccount().SingleOrDefault(a => a.AccountId == id));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Account acc)
        {
            try
            {
                if (ModelState.IsValid)
                    AccountRepo.UpdateAccount(acc);
                ViewBag.Update = "Update successfully";
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}
