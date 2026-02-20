using System;
using System.Collections.Generic;
using System.Text;

namespace Console_SalaryAdjuster
{
    public class ContractEmployee : Employee, ISalaryAdjuster
    {
        public void AdjustSalary()
        {
            decimal percentage = 5;
            EmployeeSalary += EmployeeSalary * percentage / 100;
        }
    }
}
