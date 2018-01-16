using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Person
    {
        public Person(int id, string name, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; private set; }
        public int ID { get; private set; }
        protected int Age {  get;  set; }

    public virtual void SendMessage(string message)
        {
            Console.WriteLine("'" + message + "'" + " sent to " + Name);
        }

        public abstract decimal EvaluatePerformance();
    }
}
