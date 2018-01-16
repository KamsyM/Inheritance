using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Student : Person
    {
        public Student(int id, string name, int yeargroup) : base(id, name)
        {
            YearGroup = yeargroup;
        }

        public override string ToString()
        {
            return Name ;
        }
        
        public int YearGroup { get; private set; }

        public override decimal EvaluatePerformance()
        {
            
            return 2;
        }

        public void RegisterForExam()
        {

        }
       
    }
}
