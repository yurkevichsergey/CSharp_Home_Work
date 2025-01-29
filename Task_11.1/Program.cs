/* Завдання 11.1
Написати свій власний варіант гри “Шибениця”.
Це гра, де треба вгадати посимвольно зашифроване слово.
Нехай слово вже буде відомо програмі.
Користувач може вводити по одній літері та має обмежену кількість невірних спроб.*/
char liter;
int your_tries = 10, liter_position, count_liter = 0;
var secret_word = "mountain";
bool victory = false, already_know; 
char[] secret_word_chars = secret_word.ToCharArray();
char[] your_word = {'_', '_', '_', '_', '_', '_', '_', '_'};
Console.WriteLine("Завдання 11.1");
Console.WriteLine("Вiтаємо! Спробуйте вгадати зашифроване слово!");
Console.WriteLine("Кiлькiсть лiтер у словi: 8");
Console.WriteLine($"Кiлькiсть можливих невiрних спроб: {your_tries}");
do
{
    try
    {
        liter_position = 0; already_know = false;
        Console.WriteLine("Введiть вашу лiтеру: ");
        liter = char.Parse(Console.ReadLine());
        if (char.IsLetter(liter))
        {
            for (int j = 0; j < your_word.Length; j++)      //перевірка, була вже відгадана ця літера
            {
                if (liter == your_word[j])
                    already_know = true;
            }
            if (!already_know)                              //якщо ні продовжуємо 
            {
                for (int i = 0; i < secret_word_chars.Length; i++)
                {
                    if (liter == secret_word_chars[i])
                    {
                        your_word[i] = secret_word_chars[i];
                        liter_position = ++i; ++count_liter;    
                    }
                }
                if (liter_position > 0)
                {
                    Console.WriteLine($"Така лiтера є у словi!");
                    foreach (char c in your_word)
                    {
                        Console.Write(c);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"Такоi лiтери немає! Залишилось спроб: {--your_tries}");
                }
            }
            else
            {
                Console.WriteLine($"Ви вже вводили цю лiтеру! Залишилось спроб: {--your_tries}");
            }

            if (secret_word_chars.Length == count_liter)
            {
                Console.WriteLine("Вiтаємо, ви вгадали слово! Зашифроване слово: mountain.");
                victory = true;
            }
        }
        else
            Console.WriteLine("Введiть лiтеру, а не символ або цифру");
    }
    catch (FormatException)
    {
        Console.WriteLine("Введiть лiтеру, а не символ або цифру");
    }
} while (!victory && your_tries > 0);
