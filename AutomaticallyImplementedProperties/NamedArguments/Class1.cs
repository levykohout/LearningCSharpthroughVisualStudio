using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedArguments
{
    public class Product
    {
        readonly string name;
        public string Name
        {
            get { return name; }
        }

        readonly decimal price;
        public decimal Price
        {
            get { return price; }
        }

        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>
            {
                new Product(name: "West Side Story", price: 9.99m),
                new Product(name: "Assasins", price: 14.99m),
                new Product(name: "Frogs", price: 13.99m),
                new Product(name: "Sweeney Tood", price: 10.99m)
            };
            
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", name, price);
        }
    }
}

/* The benefits of specifying the arguments names explicitely are 
 * relatively minimal in the particular example, but when a method 
 * or constructor has several parameters, it can make the remaining
 * of the code much clearer--particularly if they're of the same type,
 * or if you're passing in null for some arguments.*/