using BookLibrary.DataAccess;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BookWebApp.Controllers
{
    
    public class AuthenticationController : Controller
    {

        private AccountRepo accountRepo = new AccountRepo();
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("username");
            return RedirectToAction("List", "Books");
        }

        public IActionResult Signup()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Account account)
        {
            if(accountRepo.GetListAccount().Any(a => a.Username.Equals(account.Username)))
            {
                ViewBag.AccExisted = "Account is already existed";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("username", account.Username);
                account.RoleId = 2;
                accountRepo.AddAccount(account);
                return RedirectToAction("List", "Books");
            }
            
        }

        public IActionResult Signin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Signin(Account account)
        {
            Account acc = accountRepo.CheckAuthentication(account.Username, account.Password);
            
            if (acc != null)
            {

                HttpContext.Session.SetString("username", acc.Username);
                return RedirectToAction("List", "Books");
            }
            else
            {
                ViewBag.Error = "Username or password is not correct";
                return View();
            }
        }
    }
}
