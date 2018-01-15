using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var kamsi = new Student(1, "Kamsi", 5);
            var stacy = new Student(2, "Stacy", 5);
            kamsi.SendMessage("Hello");
            Console.WriteLine(kamsi);
            Console.ReadKey();
        }
    }

}
