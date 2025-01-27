using System;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

/*Task #1. Average sallary
Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць.
Після отримання всіх значень програма має обчислити та вивести середній заробіток.*/
Console.WriteLine("Task #1. Sallary average for 10 workers");
double sallary = 0, average = 0;
int employers = 1;
for (int i = 1; i <= employers; i++)
{
    Console.WriteLine($"Enter sallary for employee {i}:");
    try
    {
        sallary = double.Parse(Console.ReadLine());
        if (sallary < 0)
        {
            Console.WriteLine($"You enter negative number: {sallary}, please enter correct number");
            i--;
        }
        else
        {
            average += sallary;
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error, please enter the valid number");
        i--;
    }
}
average /= employers;
Console.WriteLine($"Average sallary for employers - {average}");

/*Task #2. Graphic builder
Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок.
Користувач повинен ввести кількість рядків графіка. Кожен рядок графіка має містити відповідну кількість зірочок.*/
Console.WriteLine("\nTask #2. Graphic Builder");
int graphic_strokes = 0;
string stroke = "*";
try
{
    graphic_strokes = int.Parse(Console.ReadLine());
    if (graphic_strokes < 0)
    {
        Console.WriteLine($"You enter negative number: {graphic_strokes}, please enter correct number");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error, please enter the valid number");
}
for (int i = 1; i <= graphic_strokes; i++)
{
    if (i == 1)
    {
        Console.WriteLine(stroke);
    }
    else
    {
        stroke += "*";
        Console.WriteLine(stroke);
    }
}

/*Task #3. Generator simple numbers
Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. 
Просте число - це число, яке ділиться лише на 1 і на себе.*/
Console.WriteLine("\nTask #3. Generator simple numbers");
int end_number = 0;
bool simple;
try
{
    end_number = int.Parse(Console.ReadLine());
    if (end_number < 0)
    {
        Console.WriteLine($"You enter negative number: {end_number}, please enter correct number");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error, please enter the valid number");
}
for (int i = 1; i <= end_number; i++)
{
    simple = true;
    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            simple = false;
        }
    }
    if (simple)
    {
        Console.WriteLine($"{i}");
    }
}

/*Task #4. Generator simple numbers
Перевірка паролю: Напишіть програму, яка перевіряє пароль користувача. Пароль вважається прийнятним, якщо він містить принаймні
8 символів, з яких принаймні один символ - це цифра, а також принаймні один символ - це спеціальний символ (наприклад, !, @, # тощо).*/
Console.WriteLine("\nTask #4. Password validator");
Console.WriteLine("Enter the password:");
string? password = Console.ReadLine();
bool hasDigit = false, hasSpecialChar = false;
if (password.Length >= 8)
{
    foreach (char c in password)
    {
        if (char.IsDigit(c))
        {
            hasDigit = true;
        }
        else if (!char.IsLetterOrDigit(c))
        {
            hasSpecialChar = true;
        }
    }
}

if (hasDigit && hasSpecialChar)
{
    Console.WriteLine("Password is correct");
}
else
{
    Console.WriteLine("Password is incorrect.");
}

/* Task #5. Fibonachi generator
Генерація фібоначчівської послідовності: Напишіть програму, яка генерує перші N чисел Фібоначчі. 
Послідовність Фібоначчі починається з 0 і 1, а кожне наступне число є сумою двох попередніх чисел у послідовності.*/
Console.WriteLine("\nTask #5. Fibonachi numbers generator");
int all_numbers = 0, previous_fibonachi_number = 0, current_fibonachi_number = 0, new_fibonachi_number;
Console.WriteLine("Enter the number");
try
{
    all_numbers = int.Parse(Console.ReadLine());
    if (all_numbers < 0)
    {
        Console.WriteLine($"You enter negative number: {all_numbers}, please enter correct number");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error, please enter the valid number");
}
for (int i = 1; i <= all_numbers; i++)
{
    if (i == 2)
    {
        current_fibonachi_number = 1;
        Console.WriteLine($"{new_fibonachi_number = 1}");
    }
    else if (i == 1)
    {
        Console.WriteLine($"{new_fibonachi_number = 0}");
    }
    else
    {
        new_fibonachi_number = previous_fibonachi_number + current_fibonachi_number;
        previous_fibonachi_number = current_fibonachi_number;
        current_fibonachi_number = new_fibonachi_number;
        Console.WriteLine($"{new_fibonachi_number}");
    }
}

/* Task #6. Hour sallary calculator
Калькулятор оплати праці за годину: Напишіть програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. 
Після введення значень програма має обчислити та вивести оплату за день.*/
Console.WriteLine("\nTask #6. Hour sallary calculator");
int hour;
double hour_sallary, summary_sallary_per_hour;
try
{
    Console.WriteLine("Enter the number of hours:");
    do
    {
        hour = int.Parse(Console.ReadLine());
        if (hour <= 0 | hour > 25)
        {
            Console.WriteLine($"You entered invalid number, please enter correct number");
        }
    } while (hour <= 0 | hour > 25);
    
    
    Console.WriteLine("Enter the number the sallary per hour:");
    hour_sallary = double.Parse(Console.ReadLine());
    summary_sallary_per_hour = hour * hour_sallary;
    Console.WriteLine($"Money per day - {summary_sallary_per_hour}");
}
catch (FormatException)
{
    Console.WriteLine("Error, please enter the valid number");
}

/*Task #7. Multiplication table
Генерація таблиці множення для конкретного числа: Напишіть програму, яка запитує в користувача число,
а потім генерує таблицю множення для цього числа від 1 до 10.*/
Console.WriteLine("\nTask #7. Multiplication table");
double multiplication_number = 0;
try
{
    Console.WriteLine("Enter the number:");
    multiplication_number = double.Parse(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine($"{i}. {multiplication_number} * {i} = {multiplication_number * i}");
    }
}
catch (FormatException)
{
    Console.WriteLine("Error, please enter the valid number");
}


/*Task #8. Simple number
Перевірка на простоту: Напишіть програму, яка перевіряє, чи є задане користувачем число простим.
Число вважається простим, якщо воно ділиться лише на 1 і на себе.*/
Console.WriteLine("\nTask #8. Simple number");
double is_simple_number;
bool number_is_simple = true;
try
{
    Console.WriteLine("Enter the number:");
    do
    {
        is_simple_number = int.Parse(Console.ReadLine());
        if (is_simple_number <= 0)
        {
            Console.WriteLine($"You entered invalid number, please enter the correct number, which bigger then NULL");
        }
    } while (is_simple_number <= 0);

    for (int i = 2; i <= is_simple_number/2; i++)
    {
        if (is_simple_number % i == 0)
        {
            number_is_simple = false;
            break;
        }
    }
    if (number_is_simple)
    {
        Console.WriteLine($"Your number is simple - {is_simple_number}");
    }
    else
    {
        Console.WriteLine($"Your number is NOT simple - {is_simple_number}");
    }

}
catch (FormatException)
{
    Console.WriteLine("Error, please enter the valid number");
}
