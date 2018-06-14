using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CricketKitBuilder builder = new CricketKitBuilder();
            builder.AddToCricketKit(new KokaburaBat());
            builder.AddToCricketKit(new SGBall());

            builder.DisplayMyCricketKit();
            Console.Read();
        }
    }
}
