using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class OrderItem
    {
        public Product Product { get; set; }
        public int Quantity { get; set; }

        public double PurchasePrice { get; set; }

        public bool Validate()
        {
            bool validate = !(Quantity <= 0 || Product == null);

            return validate;
        }

        public List<OrderItem> Retrieve()
        {
            List<OrderItem> list = new List<OrderItem>();

            //write code to retrieve real data.

            return list;
        }

        public OrderItem Retrieve(Product product)
        {
            OrderItem orderItem = new OrderItem();

            //write code to retrieve order from product guid

            return orderItem;
        }

        public bool Save(OrderItem orderItem)
        {
            //write code to save order item

            return true;
        }
    }
}
