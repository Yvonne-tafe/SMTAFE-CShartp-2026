namespace Console_SalaryAdjuster
{
    class program
    {
        static void Main(string[] args)
        {
            PermanentEmployee permanentEmployee = new PermanentEmployee { EmployeeName = "John Doe", EmployeeSalary = 50000m };
            ContractEmployee contractEmployee = new ContractEmployee { EmployeeName = "Jane Smith", EmployeeSalary = 40000m };
            Intern intern = new Intern { EmployeeName = "Alice Johnson", EmployeeSalary = 20000m };
            permanentEmployee.DisplayInformation();
            contractEmployee.DisplayInformation();
            intern.DisplayInformation();
            permanentEmployee.AdjustSalary();
            contractEmployee.AdjustSalary();
            intern.AdjustSalary();
            Console.WriteLine("After Salary Adjustment:\n");
            permanentEmployee.DisplayInformation();
            contractEmployee.DisplayInformation();
            intern.DisplayInformation();
        }
    }
}



