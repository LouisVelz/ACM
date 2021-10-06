using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL.Persistence
{
    public class OrderRepository
    {
        public List<Order> Retrieve()
        {
            List<Order> list = new List<Order>();

            //write functionality to return all orders
            return list;
        }

        public Order Retrieve(int orderId)
        {
            var order = new Order(1)
            {
                Customer = new Customer(1),
                OrderDate = new DateTimeOffset(),
                OrderItems = new List<OrderItem>()
            };

            //write functionality to return order
            return orderId == 1 ? order : new Order(3);
        }

        public bool Save(Order order)
        {
            //write code to save order

            return true;
        }
    }
}
