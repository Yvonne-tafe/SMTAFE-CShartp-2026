using System;
using System.Collections.Generic;
using System.Text;

namespace Console_SalaryAdjuster
{
    public abstract class Employee
    {
        public string EmployeeID { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 8);
        public string EmployeeName { get; set; }
        public decimal EmployeeSalary { get; set; }
        public void DisplayInformation()
        {
            Console.WriteLine($"EmployeeID: {EmployeeID}");
            Console.WriteLine($"EmployeeName: {EmployeeName}");
            Console.WriteLine($"EmployeeSalary: {EmployeeSalary}");
            Console.WriteLine();
        }
    }
}
