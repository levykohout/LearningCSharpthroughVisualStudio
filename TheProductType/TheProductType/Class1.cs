using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheProductType
{
    public class Product
    {
        string name;
        public string Name
        {
            get { return name; }
        }

        decimal price;
        public decimal Price
        {
            get { return price; }
        }

        public Product (string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }

        public static ArrayList GetSampleProducts()
        {
            ArrayList list = new ArrayList();
            list.Add(new Product("West Side Story", 9.99m));
            list.Add(new Product("Assasins", 14.99m));
            list.Add(new Product("Frogs", 13.99m));
            list.Add(new Product("Sweeney Todd", 10.99m));
            return list;

        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", name, price);
        }
    }
}

/*limitations:
 * ArrayList has no compile-time information about what's in it.
 * public getter properties setter has to be public too.
 *  */