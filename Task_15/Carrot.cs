using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Carrot : Product
{
    public Carrot(double basePrice) : base(name: "Carrot", basePrice) { }
    public override string Info => $"Product: {Name}, Price: {BasePrice}";
}
