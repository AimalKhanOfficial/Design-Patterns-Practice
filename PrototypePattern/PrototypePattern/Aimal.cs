using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Aimal : Person
    {

        public Aimal()
        {
            Console.WriteLine("Aimal Object Created");
        }

        public override string GetPersonName()
        {
            return "Aimal Khan";
        }
    }
}
