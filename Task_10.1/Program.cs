/*Завдання 10.1
Ви отримали рядок, який містить ім’я та прізвище користувача.
Ваша мета - перевірити, чи починається прізвище на ту ж літеру, що й ім’я.
Якщо так, вивести повідомлення “Прізвище починається на ту ж літеру, що і ім’я”,
інакше - “Прізвище не починається на ту ж літеру, що і ім’я”.*/
using System.Text;

Console.WriteLine("Task 10.1");
var name_surname = "Sergey Yurkevich";
Console.WriteLine("Example - 1: Sergey Yurkevich");
var initials = name_surname.Split(" ");
if (initials[0].FirstOrDefault(char.IsLetter) == initials[1].FirstOrDefault(char.IsLetter))
{
    Console.WriteLine("\nПрiзвище починається на ту ж лiтеру, що i iм’я");
}
else
{
    Console.WriteLine("\nПрiзвище не починається на ту ж лiтеру, що i iм’я");
}
Console.WriteLine("\n===========================================================");
Console.WriteLine("Example - 2: Sergey Surkevich");
name_surname = "Sergey Surkevich";
initials = name_surname.Split(" ");
if (initials[0].FirstOrDefault(char.IsLetter) == initials[1].FirstOrDefault(char.IsLetter))
{
    Console.WriteLine("\nПрiзвище починається на ту ж лiтеру, що i iм’я");
}
else
{
    Console.WriteLine("\nПрiзвище не починається на ту ж лiтеру, що i iм’я");
}
