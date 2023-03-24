using BookLibrary.DataAccess;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BookWebApp.Controllers
{
    public class CartController : Controller
    {
        CartRepo cartRepo = new CartRepo();
        CartDetailRepo cartDetailRepo= new CartDetailRepo();
        public IActionResult List(int accountId)
        {
            var username = HttpContext.Session.GetString("username");
            Account a = new AccountRepo().GetListAccount().SingleOrDefault(a => a.Username == username);
            Cart c = cartRepo.GetListCart().SingleOrDefault(c => c.AccountId == a.AccountId);
            if (c == null)
            {
                if (TempData["Success"] == null)
                    ViewBag.Non = "Don't have any product in cart";
                return View();
            }
            List<CartDetail> list = (List<CartDetail>)cartDetailRepo.GetListCartDetailsByCartID(c.CartId);
            var model = new Tuple<IEnumerable<CartDetail>, Cart>(list, c);
            return View(model);
        }

        [HttpPost]
        public IActionResult Add(int bookId, int quantity) {
            var username = HttpContext.Session.GetString("username");
            Account a = new AccountRepo().GetListAccount().SingleOrDefault(a => a.Username == username);
            Book book = new BookRepo().getBookByBookID(bookId);
            CartDetail cartDetail = new CartDetail()
            {
                Quantity = quantity,
                BookId = bookId
            };
            Cart cart = cartRepo.GetListCart().SingleOrDefault(c => c.AccountId == a.AccountId);
            if (cart != null)
            {
                IEnumerable<CartDetail> cartDetails = cartDetailRepo.GetListCartDetails();
                foreach (var item in cartDetails)
                {
                    if (cart.CartId == item.CartId && item.BookId == book.BookId)
                    {
                        cartDetail.Quantity = cartDetail.Quantity + item.Quantity;
                        cart.TotalMoney = cart.TotalMoney + (decimal)((quantity * book.Price * (decimal)(100.0 - book.Discount)) / (decimal)100.0);
                        cartRepo.UpdateCart(cart);
                        cartDetail.CartId = item.CartId;
                        cartDetailRepo.UpdateCartDetail(cartDetail);
                        TempData["Add"] = "Add to cart successfully";
                        return RedirectToAction("Details", "Books", new { id = bookId });
                    }
                }
                cartDetail.CartId = cart.CartId;
                cart.TotalMoney = cart.TotalMoney + (decimal)((quantity * book.Price * (decimal)(100.0 - book.Discount)) / (decimal)100.0);
                cartRepo.UpdateCart(cart);
                cartDetailRepo.AddCartDetail(cartDetail);
            }
            else
            {
                Cart cart1 = new Cart();
                cart1.AccountId = a.AccountId;
                cart1.TotalMoney = (decimal)((quantity * book.Price * (decimal)(100.0 - book.Discount)) / (decimal)100.0);
                cartRepo.AddCart(cart1);
                IEnumerable<Cart> listCart = cartRepo.GetListCart();
                listCart = cartRepo.GetListCart();
                cartDetail.CartId = listCart.Max(c => c.CartId);
                cartDetailRepo.AddCartDetail(cartDetail);
            }
            TempData["Add"] = "Add to cart successfully";
            return RedirectToAction("Details" , "Books", new {id =bookId});
        }
    }
}
