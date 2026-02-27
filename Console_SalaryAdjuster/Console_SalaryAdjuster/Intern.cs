using System;
using System.Collections.Generic;
using System.Text;

namespace Console_SalaryAdjuster
{
    public class Intern : Employee, ISalaryAdjuster
    {
        public decimal InitSaray = 2000m;
        public void AdjustSalary()
        {
            decimal bonus = 200;
            EmployeeSalary += bonus;
        }
    }
}
