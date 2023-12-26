using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program
{
    internal class AcademicDegree : EmployeeDecorator
    {
        public AcademicDegree(string name, double salary, Employee employee) : base(name, salary, employee)
        {
        }

        public string DissertationTitle { get; set; }
        public int DissertationYear { get; set; }
        public string ScienceArea { get; set; }

        public override string GetInfo()
        {
            string info = base.GetInfo() +
                "\nDissertation title: " + DissertationTitle +
                "\nYear of dissertation: " + DissertationYear +
                "\nScience area: " + ScienceArea;
            return info;
        }
    }
}
