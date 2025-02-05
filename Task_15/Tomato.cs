using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tomato : Product
{
    public Tomato(double basePrice) : base(name: "Tomato", basePrice) { }
    public override string Info => $"Product: {Name}, Price: {BasePrice}";
}
