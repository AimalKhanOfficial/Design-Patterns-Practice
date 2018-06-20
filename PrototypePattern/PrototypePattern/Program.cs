using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonCache.loadCache();


            Person person1 = (Aimal) PersonCache.GetPerson("aimal");
            Console.WriteLine(person1.GetPersonName());

            Person person2 = (Aimal)PersonCache.GetPerson("aimal");
            Console.WriteLine(person2.GetPersonName());

            Person person3 = (Asfandyar)PersonCache.GetPerson("asfandyar");
            Console.WriteLine(person3.GetPersonName());

            Person person4 = (Asfandyar)PersonCache.GetPerson("asfandyar");
            Console.WriteLine(person4.GetPersonName());

            Console.Read();

        }
    }
}
