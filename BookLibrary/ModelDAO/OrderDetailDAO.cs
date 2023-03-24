using BookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class OrderDetailDAO
    {
        public IEnumerable<OrderDetail> GetOrderDetailList()
        {
            var orderDetails = new List<OrderDetail>();
            try
            {
                using var context = new ProjectBookContext();
                orderDetails = context.OrderDetails.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return orderDetails;
        }

        

        public void AddOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                    using var context = new ProjectBookContext();
                    context.OrderDetails.Add(orderDetail);
                    context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                    using var context = new ProjectBookContext();
                    context.OrderDetails.Update(orderDetail);
                    context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveOrderDetail(OrderDetail orderDetail)
        {
            try
            {
                    using var context = new ProjectBookContext();
                    context.OrderDetails.Remove(orderDetail);
                    context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}