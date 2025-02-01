using System;
using System.Collections.Generic;

class ToDoListApp
{
    static List<ToDoItem> toDoList = new List<ToDoItem>();

    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== Список справ ===");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Вивести всi справи");
            Console.WriteLine("3. Вiдмiтити виконану справу");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("5. Вийти");
            Console.Write("Оберiть опцiю: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ShowTasks();
                    break;
                case "3":
                    MarkTaskCompleted();
                    break;
                case "4":
                    RemoveTask();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Невiрний вибiр, спробуйте ще раз.\nНатиснiть будь-яку клавiшу щоб проводовжити!");
                    Console.ReadKey();
                    break;
            }
        }
    }

    class ToDoItem
    {
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public ToDoItem(string title)
        {
            Title = title;
            IsCompleted = false;
        }
    }

    static void AddTask()
    {
        Console.Write("Введiть назву справи: ");
        string title = Console.ReadLine();
        toDoList.Add(new ToDoItem(title));
        Console.WriteLine("Справу додано!\nНатиснiть будь-яку клавiшу щоб проводовжити!");
        Console.ReadKey();
    }

    static void ShowTasks()
    {
        Console.Clear();
        if (toDoList.Count == 0)
        {
            Console.WriteLine("Список справ порожнiй.\nНатиснiть будь-яку клавiшу щоб проводовжити!");
        }
        else
        {
            Console.WriteLine("Список справ:");
            for (int i = 0; i < toDoList.Count; i++)
            {
                string status = toDoList[i].IsCompleted ? "[Виконано]" : "[Невиконано]";
                Console.WriteLine($"{i + 1}. {status} {toDoList[i].Title}");
            }
        }
        Console.WriteLine("Натиснiть будь-яку клавiшу щоб проводовжити!");
        Console.ReadKey();
    }

    static void MarkTaskCompleted()
    {
        ShowTasks();
        Console.Write("Введiть номер справи, яку потрiбно вiдмiтити як виконану: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
        {
            toDoList[index - 1].IsCompleted = true;
            Console.WriteLine("Справу вiдмiчено як виконану!\nНатиснiть будь-яку клавiшу щоб проводовжити!");
        }
        else
        {
            Console.WriteLine("Невiрний номер справи.\nНатиснiть будь-яку клавiшу щоб проводовжити!");
        }
        Console.ReadKey();
    }

    static void RemoveTask()
    {
        ShowTasks();
        Console.Write("Введіть номер справи для видалення: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= toDoList.Count)
        {
            toDoList.RemoveAt(index - 1);
            Console.WriteLine("Справу видалено!\nНатиснiть будь-яку клавiшу щоб проводовжити!");
        }
        else
        {
            Console.WriteLine("Невiрний номер справи.\nНатиснiть будь-яку клавiшу щоб проводовжити!");
        }
        Console.ReadKey();
    }
}
