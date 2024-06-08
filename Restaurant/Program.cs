using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Restaurant restaurant = new Restaurant();

            // Adding some menu items
            restaurant.AddMenuItem(new AppetizerMenuItem("Pizza","Tasty Pizza", 10));
            restaurant.AddMenuItem(new MainCourseItemMenu("Pasta", "Mushroom Pasta", 11));
            restaurant.AddMenuItem(new DessertMenuItem("Brownie","Fudgy Brownie", 5));

            // Display the menu
            restaurant.DisplayMenu();

            // Adding a customer
            Customer customer2 = new Customer("John Doe", "john.doe@example.com");
            Customer customer1 = new Customer("Maria", "john.doe@example.com");

            restaurant.AddCustomer(customer2);
            restaurant.AddCustomer(customer1);


            // Placing orders
            Order order1 = new Order();
            order1.AddMenuItem(new AppetizerMenuItem("Pizza", "Tasty Pizza", 10));
            order1.AddMenuItem(new MainCourseItemMenu("Pasta", "Mushroom Pasta", 11));
            restaurant.PlaceOrder(customer2, order1);

            Order order2 = new Order();
            order2.AddMenuItem(new DessertMenuItem("Brownie", "Fudgy Brownie", 5));
            restaurant.PlaceOrder(customer1, order2);

            // Display order history
            restaurant.DisplayOrderHistory(customer2);
            restaurant.DisplayOrderHistory(customer1);


        }
    }
}
