using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Asfandyar : Person
    {

        public Asfandyar()
        {
            Console.WriteLine("Asfandyar Object Created");
        }

        public override string GetPersonName()
        {
            return "Asfandyar Khan";
        }
    }
}
