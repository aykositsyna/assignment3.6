using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Manager : Employee
    {
        public Manager(string name, double salary) : base(name, salary) { }

        public override string GetInfo()
        {
            return base.GetInfo() + "\nJob title: Manager";
        }
    }
}
