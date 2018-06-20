using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    class CellPhone
    {
        List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
        }

        public void ShowMyItem()
        {
            foreach (var item in items)
            {
                Console.WriteLine("Item: " + item.ShowName() + ", Headphones: " + item.ShowHeadPhones().ShowType());
            }
        }
    }
}
