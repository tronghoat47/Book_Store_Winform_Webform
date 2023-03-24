using BookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class CartDAO
    {
        public IEnumerable<Cart> GetCartList()
        {
            var carts = new List<Cart>();
            try
            {
                using var context = new ProjectBookContext();
                carts = context.Carts.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return carts;
        }

        public Cart GetCartByID(int id)
        {
            Cart cart = null;
            try
            {
                using var context = new ProjectBookContext();
                cart = context.Carts.FirstOrDefault(c => c.CartId == id);
            }
            catch (Exception)
            {

                throw;
            }
            return cart;
        }

        public void AddCart(Cart cart)
        {
            try
            {
                using var context = new ProjectBookContext();
                context.Carts.Add(cart);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateCart(Cart cart)
        {
            try
            {
                using var context = new ProjectBookContext();
                context.Carts.Update(cart);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void RemoveCart(Cart cart)
        {
            try
            {
                    using var context = new ProjectBookContext();
                    context.Carts.Remove(cart);
                    context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
