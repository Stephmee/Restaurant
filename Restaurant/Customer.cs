using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Customer
    {
        private List<Order> _orderHistory=new List<Order>();
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email) 
        {
            Name = name;
            Email = email;
        }
        public void AddOrder(Order order)
        {
            _orderHistory.Add(order);
        }

        public List<Order> GetOrderHistory()
        {
            return _orderHistory;
        }
    }
}
