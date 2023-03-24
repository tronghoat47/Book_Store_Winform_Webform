using BookLibrary.DataAccess;
using BookLibrary.ModelDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.Repository
{
    public class OrderDetailRepo
    {
        private OrderDetailDAO OrderDetailDAO = new OrderDetailDAO();
        public IEnumerable<OrderDetail> GetListOrderDetail() => OrderDetailDAO.GetOrderDetailList();
        public void AddOrderDetail(List<OrderDetail> orderDetailList)
        {
            foreach (var item in orderDetailList)
            {
                OrderDetailDAO.AddOrderDetail(item);
            }
        }
    }
}
