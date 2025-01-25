using static System.Runtime.InteropServices.JavaScript.JSType;
double result = 0;
bool math_action = false;

Console.WriteLine("Enter the first number:");
string? number_1 = Console.ReadLine();
if (double.TryParse(number_1, out double correct_number_1)) { }
else
{
    Console.WriteLine("Error, please enter the number");
}

Console.WriteLine("\nEnter the second number:");
string? number_2 = Console.ReadLine();
if (double.TryParse(number_2, out double correct_number_2)) { }
else
{
    Console.WriteLine("Error, please enter the number");
}

Console.WriteLine("\nEnter the math operation (+,-,*,/):");
string? math_operator = Console.ReadLine();
switch (math_operator)
{
    case "+":
        result = correct_number_1 + correct_number_2;
        math_action = true;
        break;
    case "-":
        result = correct_number_1 - correct_number_2;
        math_action = true;
        break;
    case "*":
        result = correct_number_1 * correct_number_2;
        math_action = true;
        break;
    case "/":
        if(correct_number_2 == 0)
        {
            Console.WriteLine("\nValue of second number is 0 (zero), impossible action");
            break;
        }
        else
        {
            result = correct_number_1 / correct_number_2;
        }
        math_action = true;
        break;
    default:
        Console.WriteLine("Invalid math operator");
        break;
}
if (correct_number_2 != 0 && math_action == true)
{
    Console.WriteLine($"\nResult = {result}");
}
