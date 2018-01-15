using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Person
    {
        public Person(int id, string name)
        {
            Name = name;
            ID = id;
        }

        public string Name { get; private set; }
        public int ID { get; private set; }
        public void SendMessage(string message)
        {
            Console.WriteLine("'" + message + "'" + " sent to " + Name);
        }

        public abstract decimal EvaluatePerformance();
    }
}
