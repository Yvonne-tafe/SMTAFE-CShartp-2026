// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.Write("enter two number, split by comma :");
string input_numbers_string = Console.ReadLine();
string[] input_numbers = input_numbers_string.Split(',');
string output_numbers = "";
foreach (string input_number in input_numbers)
{
    double double_value = Convert.ToDouble(input_number);
    Console.WriteLine("\n double value is: " + double_value);
    output_numbers += "double value is: " + double_value.ToString() + "\n";
}
File.AppendAllText("calc.txt", string.Join("\n", output_numbers));
string f_path = Path.GetFullPath("calc.txt");
Console.WriteLine(f_path);


