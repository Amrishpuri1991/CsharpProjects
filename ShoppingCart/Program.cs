using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    public class Product
    {
        public string Name;
        public double Price;


    }

    public class ShppoingCart
    {
        public string Name;
        public double Price;
        public int qty;
        public double TotalPrice;


    }

    class Program
    {
        static void Main(string[] args)
        {
            MainMenu();





        }


        static void MainMenu()
        {
            List<Product> products = new List<Product>();

            products.Add(new Product() { Name = "1. Milk", Price = 4 });
            products.Add(new Product() { Name = "2. Apple", Price = 1 });
            products.Add(new Product() { Name = "3. Chocolate", Price = 3 });
            products.Add(new Product() { Name = "4. Banana", Price = 0.5 });
            products.Add(new Product() { Name = "5. Biscuits", Price = 2 });


            Console.Clear();
            Console.WriteLine("Welcome to Shopping app");
            Console.WriteLine("********************************************");
            Console.WriteLine("Press appropriate number to select product");
            foreach (var item in products)
            {
                Console.WriteLine("Avaiable Product = " + item.Name + " - Price: " + "$" + item.Price);

            }
            Console.WriteLine("Press 6 to exit");
            int myOptions;
            myOptions = Convert.ToInt32(Console.ReadLine());

            switch (myOptions)
            {
                case 1:
                    Shopcart();
                    Console.Read();
                    break;
                case 2:
                    Console.WriteLine("You have pressed 2");
                    break;
                case 3:
                    Console.WriteLine("You have pressed 3");
                    break;
                case 4:
                    Console.WriteLine("You have pressed 4");
                    break;
                case 5:
                    Console.WriteLine("You have pressed 5");
                    break;
                case 6:
                    Console.WriteLine("You have pressed 6");
                    break;
            }
            //MainMenu();
        }
        static void Shopcart()
        {

            Console.Write("Enter the Qty : ");
            int qt = Convert.ToInt32(Console.ReadLine());
            List<ShppoingCart> sc = new List<ShppoingCart>();
            sc.Add(new ShppoingCart() { Name = "Milk", Price = 4, qty = qt, TotalPrice = (4 * qt) });
            Console.WriteLine("product Added");
            Console.WriteLine("press 1 to add more item or press 2 to exit.");
            Console.ReadLine();

            //foreach (var item in sc)
            //{
            //    Console.WriteLine(item.Name + " : " + item.Price  +" : " + item.qty  +" : " + item.TotalPrice);
            //}



        }
    }
}
