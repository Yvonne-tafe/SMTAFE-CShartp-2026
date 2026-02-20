using System;
using System.Collections.Generic;
using System.Text;

namespace Console_SalaryAdjuster
{
    public class PermanentEmployee : Employee, ISalaryAdjuster
    {
        public void AdjustSalary()
        {
            decimal percentage = 10;
            decimal bonus = 1000;
            EmployeeSalary += EmployeeSalary * percentage / 100 + bonus;
        }
    }
}
