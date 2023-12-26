using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Scientist : Employee
    {
        public Scientist(string name, double salary) : base(name, salary) { }

        public override string GetInfo()
        {
            return base.GetInfo() + "\nJob title: Scientist\n";
        }
    }
}
