using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Restaurant
    {
        private List<Customer> _customers=new List<Customer>();
        private List<MenuItem> _menu=new List<MenuItem>();

        public void AddCustomer(Customer customer)
        {
            _customers.Add(customer);
        }

        public MenuItem GetMenuItem(int index)
        {
            if(index<0||index>_menu.Count)
            {
                throw new IndexOutOfRangeException();
            }
            return _menu[index];
        }

        public void AddMenuItem(MenuItem item) 
        {
            _menu.Add(item);
        }

        public void PlaceOrder(Customer customer,Order order)
        {
            customer.AddOrder(order);
        }

        public void DisplayMenu()
        {
            Console.WriteLine("Menu Items: ");
            foreach(MenuItem item in _menu )
            { 
                Console.WriteLine(item.ToString());
            }
        }

        public void DisplayOrderHistory(Customer customer)
        {
            Console.WriteLine($"{customer.Name}'s Order History:");

            foreach (Order order in customer.GetOrderHistory())
            {
                Console.WriteLine("Order Details:");
                foreach (MenuItem item in order.GetItems())
                {
                    Console.WriteLine($"{item.Name}-{item.Description}-{item.Price}$");
                }
                Console.WriteLine($"Total: {order.GetTotal()}$");
                Console.WriteLine();
            }
        }

    }
}
