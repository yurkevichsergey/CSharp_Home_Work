using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Enter number of the day 1-7:");
string? number = Console.ReadLine();

if (int.TryParse(number, out int correct_number))
    {
    if (correct_number == 1)
    {
        Console.WriteLine("Current weekday - Monday");
    }
    else if (correct_number == 2)
    {
        Console.WriteLine("Current weekday - Tuesday");
    }
    else if (correct_number == 3)
    {
        Console.WriteLine("Current weekday - Wednesday");
    }
    else if (correct_number == 4)
    {
        Console.WriteLine("Current weekday - Thursday");
    }
    else if (correct_number == 5)
    {
        Console.WriteLine("Current weekday - Friday");
    }
    else if (correct_number == 6)
    {
        Console.WriteLine("Current weekday - Saturday");
    }
    else if (correct_number == 7)
    {
        Console.WriteLine("Current weekday - Sunday");
    }
    else
    {
        Console.WriteLine("You entered invalid number");
    }
}
else
{
    Console.WriteLine("Error, please enter the number of the day 1-7");
}
