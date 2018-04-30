using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{


    public class Person
    {
        public string Name;

        public void Introduce(string u)
        {
            Console.WriteLine("Hi  {0}, I Am {1}" ,Name,u);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            person.Name = "Asif";
            person.Introduce("John");
        }
    }
}
