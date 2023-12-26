using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class Sberbank : IBankService
    {
        public string Name { get; set; } = "Sberbank";

        public double CalculateSalary(double baseSalary)
        {
            double tax = baseSalary * 0.01;
            double finalSalary = baseSalary - tax;
            return finalSalary;
        }
    }
}
