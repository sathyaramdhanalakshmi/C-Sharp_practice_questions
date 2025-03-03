using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_practiceques
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual double GetDiscountedPrice()
        {
            return Price; //(0% discount)
        }
    }

    public class ElectronicProduct : Product
    {
        public ElectronicProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.90; //(10% discount)
        }
    }

    public class ClothingProduct : Product
    {
        public ClothingProduct(string name, double price) : base(name, price) { }

        public override double GetDiscountedPrice()
        {
            return Price * 0.80; // (20% discount)
        }
    }

}
