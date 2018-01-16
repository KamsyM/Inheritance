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
            var mathias = new PartTimeTeacher(1, "Mathias", 20);
            kamsi.SendMessage("Hello");
            mathias.SendMessage("Hello");
            Console.WriteLine();
            Console.WriteLine(kamsi);
            Student obj = new Student(3, "Object", 4);
            Console.WriteLine(obj);
            Console.ReadKey();
        }
    }

}
