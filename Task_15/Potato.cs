using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Potato : Product
{
    public double Count { get; private set; }
    public override double Price => BasePrice * Count;

    public Potato(double basePrice, double count) : base(name: "Potato", basePrice)
    {
        Count = count;
    }
    public override string Info => $"Product: {Name}, Count: {Count}, Total price: {Price}";
}
