using System.Text;
/* Завдання 10.2
Ви розробляєте програму для генерації текстового звіту.
Ваше завдання - створити текстовий звіт, який містить заголовок, дату та список подій.
Використайте StringBuilder, щоб зберегти пам’ять та оптимізувати об’єднання рядків.
Користувач у циклi буде вводити подiї, треба додавати їх у загальний список подiй типу StringBuilder .*/

StringBuilder day_report = new StringBuilder();

day_report.AppendLine("========== Звiт подiй за поточну добу ==========");
day_report.AppendLine($"Дата звiту: {DateTime.Now:yyyy-MM-dd HH:mm}");
day_report.AppendLine("------------------------------------");
StringBuilder eventsList = new StringBuilder();
Console.WriteLine("Введiть подii (порожнiй рядок для завершення/створення звiту):");
while (true)
{
    Console.Write("* ");
    string input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
        break;

    eventsList.AppendLine($"- {input}");
}

if (eventsList.Length == 0)
{
    day_report.AppendLine("Немає подiй.");
}
else
{
    day_report.AppendLine("Список подiй за поточну добу:");
    day_report.Append(eventsList);
}
Console.Clear();
Console.WriteLine(day_report.ToString());
