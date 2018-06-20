using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class PersonCache
    {
        static Dictionary<string, Person> dictionary = new Dictionary<string, Person>();

        public static Person GetPerson(string name)
        {
            Person person = (Person) dictionary[name];
            return (Person) person.Clone();
        }

        public static void loadCache()
        {
            dictionary.Add("aimal", new Aimal());
            dictionary.Add("asfandyar", new Asfandyar());
        }
    }
}
