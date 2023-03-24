using BookLibrary.DataAccess;
using BookLibrary.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace BookWebApp.Controllers
{
    public class OrderController : Controller
    {
        OrderRepo orderRepo = new OrderRepo();
        public IActionResult List(int id)
        {
            Account a = new AccountRepo().GetListAccount().SingleOrDefault(a => a.AccountId== id);
             ViewBag.RoleId = a.RoleId;
            List<Order> orders;
            if(a.RoleId == 1) {
                 orders = orderRepo.GetListOrder().OrderByDescending(o => o.OrderId).ToList();
            }else
                 orders = orderRepo.GetListOrder().OrderByDescending(o=>o.OrderId).Where(o => o.AccountId == id).ToList();
            if(orders.IsNullOrEmpty()) {
                ViewBag.Non = "You have't purchased yet";
                return View();
            }
            return View(orders);
        }

        public IActionResult Purchase(int id) {
            Account infoAccount = new AccountRepo().GetListAccount().SingleOrDefault(a => a.AccountId == id);
            Cart cart = new CartRepo().GetListCart().SingleOrDefault(c => c.AccountId== id);
            List<CartDetail> cartDetails = new CartDetailRepo().GetListCartDetails().Where(c => c.CartId == cart.CartId).ToList();

            Order order = new Order
            {
                AccountId = infoAccount.AccountId,
                OrderDate = DateTime.UtcNow,
                Note = "",
                ShippingAddress = infoAccount.Address,
                Status = "Giao hàng thành công",
                TotalMoney = cart.TotalMoney
            };
            orderRepo.AddOrder(order);

            int orderDetailID = orderRepo.GetListOrder().Max(o => o.OrderId);
            List<OrderDetail> orderDetails = new List<OrderDetail>();
            foreach (CartDetail cartDetail in cartDetails)
            {
                orderDetails.Add(new OrderDetail
                {
                    OrderId = orderDetailID,
                    BookId = cartDetail.BookId,
                    Quantity = (int)cartDetail.Quantity
                });
                BookRepo bookRepo = new BookRepo();
                Book book1 = bookRepo.getBookByBookID(cartDetail.BookId);
                if (book1.Sold == null)
                    book1.Sold = 0;
                book1.Sold = book1.Sold + cartDetail.Quantity;
                bookRepo.UpdateBook(book1);
            }
            new OrderDetailRepo().AddOrderDetail(orderDetails);

            new CartRepo().RemoveCart(cart);

            TempData["Success"] = "Purchase successfully";
            return RedirectToAction("List", "Cart");
        }
    }
}
