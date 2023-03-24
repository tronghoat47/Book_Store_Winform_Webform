using BookLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ModelDAO
{
    public class OrderDAO
    {
        public IEnumerable<Order> GetOrderList()
        {
            var orders = new List<Order>();
            try
            {
                using var context = new ProjectBookContext();
                orders = context.Orders.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            return orders;
        }

        public Order GetOrderByID(int id)
        {
            Order order = null;
            try
            {
                using var context = new ProjectBookContext();
                order = context.Orders.FirstOrDefault(c => c.OrderId == id);
            }
            catch (Exception)
            {
                throw;
            }
            return order;
        }

        public void AddOrder(Order order)
        {
            try
            {
                Order _order = GetOrderByID(order.OrderId);
                if (_order == null)
                {
                    using var context = new ProjectBookContext();
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The order is already exists");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void UpdateOrder(Order order)
        {
            try
            {
                Order _order = GetOrderByID(order.OrderId);
                if (_order != null)
                {
                    using var context = new ProjectBookContext();
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The order does not already exists");
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void RemoveOrder(int orderId)
        {
            try
            {
                Order order = GetOrderByID(orderId);
                if (order != null)
                {
                    using var context = new ProjectBookContext();
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                else
                    throw new Exception("The order does not already exists");
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}