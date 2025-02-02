using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Account
    {
    public string name { get; set; } = "";
    public double funds { get; set; } = 0;

    public Account(string name, double funds)
    {
        this.name = name;
        this.funds = funds;
    }

    public void Show_funds()
    {
        Console.WriteLine($"{name}: {funds}");
    }
    public double Deposit()
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Введiть суму:");
            double cash = double.Parse(Console.ReadLine());
            if (cash > 0)
            {
                this.funds += cash;
                Console.WriteLine($"Сумма {cash} успiшно додана до рахунку.");
            }
            else
            {
                Console.WriteLine("Введiть корректну суму. Натиснiть будь-яку клавiшу щоб продовжити.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Введiть корректну суму. Натиснiть будь-яку клавiшу щоб продовжити.");
        }
        Console.WriteLine("Натиснiть будь-яку клавiшу щоб продовжити.");
        Console.ReadKey();
        return this.funds;
    }
    public double Withdraw()
    {
        Console.Clear();
        try
        {
            Console.WriteLine("Введiть суму:");
            double cash = double.Parse(Console.ReadLine());
            if (this.funds > cash && cash > 0)
            {
                this.funds -= cash;
                Console.WriteLine($"Сумма {cash} успiшно знята з рахунку.");
            }
            else if (this.funds < cash)
            {
                Console.WriteLine("Недостатньо коштiв на рахунку. Натиснiть будь-яку клавiшу щоб продовжити.");
            }
            else 
            {
                Console.WriteLine("Введiть корректну суму. Натиснiть будь-яку клавiшу щоб продовжити.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Введiть корректну суму. Натиснiть будь-яку клавiшу щоб продовжити.");
        }
        Console.WriteLine("Натиснiть будь-яку клавiшу щоб продовжити.");
        Console.ReadKey();
        return this.funds;
    }
}

