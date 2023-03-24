using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class CartRepo
    {
        private CartDAO CartDAO = new CartDAO();

        public IEnumerable<Cart> GetListCart() => CartDAO.GetCartList();
        public void AddCart(Cart cart) => CartDAO.AddCart(cart);
        public void RemoveCart(Cart cart) => CartDAO.RemoveCart(cart);
        public void UpdateCart(Cart cart) => CartDAO.UpdateCart(cart);
    }
}
