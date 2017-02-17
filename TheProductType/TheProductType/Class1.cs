using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheProductType;

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

        public Product(string name, decimal price)
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
    //Sorting by Name
    public class ProductNameComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;
            return first.Name.CompareTo(second.Name);
        }

     
      
    }

    public class SortArrayList
    {
        ArrayList products = Product.GetSampleProducts();

        //Something is wrong here.

    SortArrayList.products.Sort (new ProductNameComparer());
        foreach(Product product in products)
            {
            Console.WriteLine(product);
            }
}

  
  

}

/*limitations:
 * ArrayList has no compile-time information about what's in it.
 * public getter properties setter has to be public too.
 *  */