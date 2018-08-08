using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child1 = new Child();
            child1.Id = "Aimal";
            Console.WriteLine("Child1: {0}, Value: {1}",child1.GetHashCode(), child1.Id);

            //Aimal Khan
            //August 7th 2018
            //This reduces the overhead of 
            //1- new object creation
            //2- populating data to the properties of the newly created object
            Child child2 = (Child) child1.Clone();
            Console.WriteLine("Child2: {0}, Value: {1}", child2.GetHashCode(), child2.Id);
            Console.ReadLine();
        }
    }
}
