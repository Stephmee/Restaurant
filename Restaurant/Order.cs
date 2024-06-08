using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public  class Order
    {
        private List<MenuItem> _items=new List<MenuItem>();

        public void AddMenuItem(MenuItem item)
        {
            _items.Add(item);
        }

        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (MenuItem item in _items)
            {
                total += item.Price;
            }
            return total;
        }

        public List<MenuItem> GetItems()
        {
            return _items;
        }
    }
}
