using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class AcademicDegree : EmployeeDecorator
    {
        public AcademicDegree(Employee employee) : base(employee.Name, employee.BaseSalary, employee)
        {
        }

        public string DissertationTitle { get; set; }
        public int DissertationYear { get; set; }
        public string ScienceArea { get; set; }

        public override string GetInfo()
        {
            string info = employee.GetInfo() +
                "\n" + Separator.GetSeparator("-", 10) +
                "\nDissertation title: " + DissertationTitle +
                "\nYear of dissertation: " + DissertationYear +
                "\nScience area: " + ScienceArea +
                "\n";
            return info;
        }
    }
}
