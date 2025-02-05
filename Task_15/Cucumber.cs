using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Cucumber : Product
{
    public double Count { get; private set; } // Кількість кілограмів
    public override double Price => BasePrice * Count; // Ціна = базова ціна * кілограми

    public Cucumber(double basePrice, double count) : base(name: "Cucumber", basePrice)
    {
        Count = count;
    }
    public override string Info => $"Product: {Name}, Count: {Count}, Total price: {Price}";
}
