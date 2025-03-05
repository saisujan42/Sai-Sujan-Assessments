using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAssessment2
{
    public class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }

        public Product(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public void GetDiscountedPrice()
        {
            Console.WriteLine("Product Discount Rate = 5%");
            Console.WriteLine("Original Price = " + Price);

            double Discount = Price * 0.05;
            Price -= Discount;
            
            Console.WriteLine("Discounted Price = " + Price);
        }
    }

    public class ElectronicProduct : Product
    {
        public ElectronicProduct(string Name, double Price) : base(Name, Price)
        { }

        public new void GetDiscountedPrice()
        {
            Console.WriteLine();
            Console.WriteLine("Electronic Product Discount Rate = 10%");
            Console.WriteLine("Original Price = " + Price);

            double Discount = Price * 0.1;
            Price -= Discount;

            Console.WriteLine("Discounted Price = " + Price);
        }
    }

    public class ClothingProduct : Product
    {
        public ClothingProduct(string Name, double Price) : base(Name, Price)
        { }

        public new void GetDiscountedPrice()
        {
            Console.WriteLine();
            Console.WriteLine("Clothing Product Discount Rate = 15%");
            Console.WriteLine("Original Price = " + Price);

            double Discount = Price * 0.15;
            Price -= Discount;

            Console.WriteLine("Discounted Price = " + Price);
        }
    }
}
