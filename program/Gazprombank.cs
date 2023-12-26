using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Gazprombank : IBankService
    {
        public string Name { get; set; } = "Gazprombank";

        public double CalculateSalary(double baseSalary)
        {
            double tax = baseSalary * 0.015;
            double finalSalary = baseSalary - tax;
            return finalSalary;
        }
    }
}
