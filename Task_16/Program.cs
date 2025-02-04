/* Завдання 16
Ваша мета - створити програму, яка копіює вміст одного текстового файлу в інший.
Користувач повинен ввести шлях до вихідного файлу та шлях до файлу, в який потрібно скопіювати дані.
Після виконання копіювання виведіть повідомлення про успішне завершення.*/

try
{
    Console.Write("Введiть шлях до вихiдного файлу: ");
    string sourcePath = Console.ReadLine();

    if (!File.Exists(sourcePath))
    {
        Console.WriteLine("Помилка: вихiдний файл не iснує.");
        return;
    }
    Console.Write("Введiть шлях до файлу-призначення: ");
    string destinationPath = Console.ReadLine();

    File.Copy(sourcePath, destinationPath, true);
    Console.WriteLine("Файл успiшно скопiйовано!");
}
catch (Exception ex)
{
    Console.WriteLine($"Помилка: {ex.Message}");
}
