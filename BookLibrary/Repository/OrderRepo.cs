using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class OrderRepo
    {
        private OrderDAO orderDAO = new OrderDAO();
        public IEnumerable<Order> GetListOrder() => orderDAO.GetOrderList();
        public void AddOrder(Order order) => orderDAO.AddOrder(order);
        public void UpdateOrder(Order order) => orderDAO.UpdateOrder(order);
    }
}
