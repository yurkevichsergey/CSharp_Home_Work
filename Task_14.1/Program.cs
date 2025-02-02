/* Завдання 14.1
1.Створіть окремий проект.
2.Створіть новий клас Account, що буде означати банківський рахунок.
Кожен рахунок має свою назву та початкову сумму грошей на рахунку.
Стан рахунку не може бути менше за 0.
Реалізувати можливість додавати гроші на рахунок та віднімати гроші з рахунку.
Реалізувати можливість отримати поточний стан рахунку, але не змінювати його напряму.*/
Account PrivateBankAccount = new Account("PrivateBank", 10000);
Account MonobankAccount = new Account("Monobank", 50000);
while (true)
{
    Console.Clear();
    Console.WriteLine("=== Поточнi рахунки в банках: ===");
    PrivateBankAccount.Show_funds();
    MonobankAccount.Show_funds();
    Console.WriteLine("=== Варiанти дiй ===");
    Console.WriteLine("1. Додати грошi до рахунку ПриватБанку");
    Console.WriteLine("2. Зняти грошi з рахунку ПриватБанку");
    Console.WriteLine("3. Додати грошi до рахунку Монобанка");
    Console.WriteLine("4. Зняти грошi з рахунку Монобанка");
    Console.WriteLine("5. Вийти");
    Console.Write("Оберiть опцiю: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            PrivateBankAccount.Deposit();
            break;
        case "2":
            PrivateBankAccount.Withdraw();
            break;
        case "3":
            MonobankAccount.Deposit();
            break;
        case "4":
            MonobankAccount.Withdraw();
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Невiрний вибiр, спробуйте ще раз.\nНатиснiть будь-яку клавiшу щоб проводовжити!");
            Console.ReadKey();
            break;
    }
}
