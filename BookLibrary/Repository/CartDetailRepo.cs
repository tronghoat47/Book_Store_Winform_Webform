using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class CartDetailRepo
    {
        private CartDetailDAO cartDetailDAO = new CartDetailDAO();
        public IEnumerable<CartDetail> GetListCartDetails() => cartDetailDAO.GetCartDetailList();
        public IEnumerable<CartDetail> GetListCartDetailsByCartID(int cartID) => cartDetailDAO.GetListCartDetailByCartId(cartID);
        public void UpdateCartDetail(CartDetail cartDetail) => cartDetailDAO.UpdateCartDetail(cartDetail);
        public void AddCartDetail(CartDetail cartDetail) => cartDetailDAO.AddCartDetail(cartDetail);

        public void RemoveCartDetail(CartDetail cartDetail)
        {
            cartDetailDAO.RemoveCartDetail(cartDetail);
        }
    }
}
