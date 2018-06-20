using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPatternMixedWithFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemBuilder item = new ItemBuilder();
            CellPhone iphoneX = item.IphoneXOrder();
            iphoneX.ShowMyItem();
            Console.Read();
        }
    }
}
