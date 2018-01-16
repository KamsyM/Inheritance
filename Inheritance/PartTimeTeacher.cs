using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class PartTimeTeacher : Teacher
    {
        public PartTimeTeacher(int id, string name, int hoursperweek) : base(id, name)
        {
            HoursPerWeek = hoursperweek;
        }

        public int HoursPerWeek { get; private set; }

        public override decimal EvaluatePerformance()
        {
            return 1;
        }

        public override void SendMessage(string message)
        {
            base.SendMessage(message);
            Console.WriteLine("Hard copy ALSO left in pigeon hole");
        }


    }
}
