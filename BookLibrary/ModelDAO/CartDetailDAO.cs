using BookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class CartDetailDAO
    {
        public IEnumerable<CartDetail> GetCartDetailList()
        {
            var cartDetails = new List<CartDetail>();
            try
            {
                using var context = new ProjectBookContext();
                cartDetails = context.CartDetails.ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return cartDetails;
        }

        public IEnumerable<CartDetail> GetListCartDetailByCartId(int cartId)
        {
            var cartDetails = new List<CartDetail>();
            try
            {
                using var context = new ProjectBookContext();
                cartDetails = context.CartDetails.Where(c => c.CartId == cartId).ToList();
            }
            catch (Exception)
            {

                throw;
            }
            return cartDetails;
        }

        public void AddCartDetail(CartDetail cartDetail)
        {
            try
            {
                using var context = new ProjectBookContext();
                context.CartDetails.Add(cartDetail);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void UpdateCartDetail(CartDetail cartDetail)
        {
            try
            {
                using var context = new ProjectBookContext();
                context.CartDetails.Update(cartDetail);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void RemoveCartDetail(CartDetail cart)
        {
            try
            {
                    using var context = new ProjectBookContext();
                    context.CartDetails.Remove(cart);
                    context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}




