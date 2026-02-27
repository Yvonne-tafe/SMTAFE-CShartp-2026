using System;
using System.Collections.Generic;
using System.Text;

namespace Console_SalaryAdjuster
{
    public class CasualEmployee : Employee, ISalaryAdjuster
    {
        public void AdjustSalary()
        {
            decimal percentage = 7;
            EmployeeSalary += EmployeeSalary * percentage / 100;
        }
    }
}
