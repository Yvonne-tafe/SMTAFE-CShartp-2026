// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

Console.Write("enter two number, split by comma :");
string input_numbers_string = Console.ReadLine();
string[] input_numbers = input_numbers_string.Split(',');
double multiplied_value = 1.0;
string output_numbers = "";
foreach (string input_number in input_numbers)
{
    double double_value = Convert.ToDouble(input_number);
    Console.WriteLine("\n double value is: " + double_value.ToString());
    output_numbers += "double value is: " + double_value.ToString() + "\n";
    multiplied_value = multiplied_value * double_value;
}
Console.WriteLine("\n The multiplied value is: " + multiplied_value.ToString());
output_numbers += "The multiplied value is: " + multiplied_value.ToString() + "\n";

//File.AppendAllText("calc.txt", string.Join("\n", output_numbers));
File.WriteAllText("calc.txt", string.Join("\n", output_numbers));
string f_path = Path.GetFullPath("calc.txt");
Console.WriteLine(f_path);


