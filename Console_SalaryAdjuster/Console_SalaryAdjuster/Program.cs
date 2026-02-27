namespace Console_SalaryAdjuster
{
    class program
    {
        static void Main(string[] args)
        {
            List<Employee> EmployeeList = new List<Employee> { new PermanentEmployee { EmployeeName = "John Doe", EmployeeSalary = 50000m }, 
                                            new ContractEmployee { EmployeeName = "Jane Smith", EmployeeSalary = 40000m }, 
                                            new Intern { EmployeeName = "Alice Johnson", EmployeeSalary = 20000m } };
            Console.WriteLine("Before Salary Adjustment:\n");
            EmployeeList.ForEach(employee => employee.DisplayInformation());
            EmployeeList.ForEach(employee => ((ISalaryAdjuster)employee).AdjustSalary());
            Console.WriteLine("After Salary Adjustment:\n");
            EmployeeList.ForEach(employee => employee.DisplayInformation());
        }
    }
}



