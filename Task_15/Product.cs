using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Product
{
    protected double BasePrice;
    public string Name { get; protected set; }
    public virtual double Price => BasePrice;
    public virtual string Info => $"Product: {Name}, Price: {BasePrice}";

    public Product(string name, double basePrice)
    {
        Name = name;
        BasePrice = basePrice;
    }
}
