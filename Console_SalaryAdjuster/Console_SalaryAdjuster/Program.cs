class program
{
    static void Main(string[] args)
    {
        PermanentEmployee permanentEmployee = new PermanentEmployee { EmployeeName = "John Doe", EmployeeSalary = 50000 };
        ContractEmployee contractEmployee = new ContractEmployee { EmployeeName = "Jane Smith", EmployeeSalary = 40000 };
        Intern intern = new Intern { EmployeeName = "Alice Johnson", EmployeeSalary = 20000 };
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
public abstract class Employee
{
    public string EmployeeID { get; set; } = Guid.NewGuid().ToString("N").Substring(0, 8);
    public string EmployeeName { get; set; }
    protected decimal EmployeeSalary { get; set; }
    public void DisplayInformation()
    {
        Console.WriteLine($"EmployeeID: {EmployeeID}");
        Console.WriteLine($"EmployeeName: {EmployeeName}");
        Console.WriteLine($"EmployeeSalary: {EmployeeSalary}");
        Console.WriteLine();
    }
}
public interface ISalaryAdjuster
{
    void AdjustSalary();
}

public class PermanentEmployee : Employee, ISalaryAdjuster
{
    public void AdjustSalary()
    {
        decimal percentage = 10;
        decimal bonus = 1000;
        EmployeeSalary += EmployeeSalary * percentage / 100 + bonus;
    }
}
public class ContractEmployee : Employee, ISalaryAdjuster
{
    public void AdjustSalary()
    {
        decimal percentage = 5;
        EmployeeSalary += EmployeeSalary * percentage / 100;
    }
}
public class Intern : Employee, ISalaryAdjuster
{
    public void AdjustSalary()
    {
        decimal bonus = 200;
        EmployeeSalary += bonus;
    }

}