/*Завдання 1.
Створити масив із 10 елементів типу int. Присвоїти їм випадкові значення від -10 до 10, 
використовуючи клас Random (https://learn.microsoft.com/en-us/dotnet/api/system.random?view=net-8.0)
Вивести на екран елементи масиву з парним індексом. (не парні значення, а саме парні індекси!!)*/
Console.WriteLine("Task #1:");
int[] array1 = new int[10];
Random rand = new Random();
Console.WriteLine("All even elements of random array:");
for (int i = 0; i < array1.Length; i++)
{
    array1[i] = rand.Next(-10, 11);
    if (i % 2 == 0)
    {
        Console.Write(array1[i] + " ");
    }
}

/*Завдання 2.
Визначити, чи вірно, що сума елементів масиву з пункту 1 є невід'ємне число.*/
Console.WriteLine("\n\nTask #2:");
int array1_even_sum = 0;
for (int i = 0; i < array1.Length; i++)
{
    if (i % 2 == 0)
    {
        array1_even_sum += array1[i];
    }
}
if (array1_even_sum > 0)
{
    Console.WriteLine($"All even array elements sum = {array1_even_sum}, which bigger then 0.");
}
else
{
    Console.WriteLine($"All even array elements sum = {array1_even_sum}, which smaller then 0.");
}

/*Завдання 3.
Створити та заповнити двовимірний масив розміру 9х9 з результатами таблиці множення 
(у першому рядку мають бути записані добутки кожного з чисел від 1 до 9 на 1, у другому – на 2, ..., в останньому – на 9).
Тобто в 1 строчці будуть значення від 1 до 9, а у другому 2,4,6,....,18 і т.д.*/
Console.WriteLine("\nTask #3:");
Console.WriteLine("Multiplication Table from 1 to 9:");
int[,] array2 = new int[9, 9];
for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        array2[i, j] = (i + 1) * (j + 1);
        Console.Write(array2[i, j] + "\t");
    }
    Console.WriteLine();
}

/*Завдання 4.
Створити двовимірний масив 5х5. Заповнити його будь-якими числами. 
Визначити та вивести на екран: 
а) максимальний елемент масиву; 
б) мінімальний елемент масиву; 
в) координати мінімального елемента масиву. 
г) координати максимального елемента масиву.*/
Console.WriteLine("\nTask #4:");
Console.WriteLine("Print random array on screen:");
int[,] array_task_4 = new int[5, 5];
int array_max = 0, array_min = array_task_4[0, 0];
for (int i = 0; i < 5; i++)
{
    for(int j = 0;j < 5; j++)
    {
        array_task_4[i, j] = rand.Next(-100, 101);
        Console.Write(array_task_4[i, j] + "\t");
        if (array_max < array_task_4[i,j])
        {
            array_max = array_task_4[i,j];
        }
        if (array_min > array_task_4[i, j])
        {
            array_min = array_task_4[i,j];
        }
    }
    Console.WriteLine();
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        if (array_max == array_task_4[i, j])
        {
            Console.WriteLine($"\nMaximum value in array = {array_max}\nIndex of maximum element [{i}, {j}]");
        }
        if (array_min == array_task_4[i, j])
        {
            Console.WriteLine($"\nMinimum value in array = {array_min}\nIndex of minimum element [{i}, {j}]");
        }
    }
}

/*Завдання 5.
За допомогою enum створити програму, що буде запитувати у користувача кількість днів, 
а потім рахувати який буде день через введену кількість, якщо рахувати від понеділка і виводити результат*/
Console.WriteLine("\nTask #5:");
int day = -1, dayIndex;
do
{
    try
    {
        Console.WriteLine("Enter the number of day:");
        day = int.Parse(Console.ReadLine());
        if (day < 0)
        {
            Console.WriteLine($"You enter negative number: {day}, please enter correct number");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Error, please enter the valid number");
    }
} while (day < 0);

dayIndex = day % 7;
weekDay resultDay = (weekDay)dayIndex;
Console.WriteLine($"Entered day - {resultDay}.");
enum weekDay
{
    Monday, 
    Tuesday, 
    Wednesday, 
    Thursday, 
    Friday, 
    Saturday, 
    Sunday 
}
