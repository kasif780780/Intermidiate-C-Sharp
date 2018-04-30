using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter01
{


    public class Person
    {
        

        public void Introduce(string v)
        {
            Console.WriteLine("Hi Am {0}",v);
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
           
            person.Introduce("Asif");
        }
    }
}
