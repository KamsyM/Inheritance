using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Teacher : Person
    {
        public Teacher(int id, string name) : base(id, name)
        {
        }

        public override decimal EvaluatePerformance()
        {
            return 1;
        }
    }
}
