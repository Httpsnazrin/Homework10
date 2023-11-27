using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace homework10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] basket = new Fruit[]
            {
                new Apple { Price = 1.8m, Sort = "Cennet almasi", VitaminA = 10, VitaminB = 5 },
                new Pineapple { Price = 6.0m, Sort = "Kayenna", VitaminE = 8, VitaminD = 3 },
                new Orange { Price = 2.3m, Sort = " Vaşinqton Navel", VitaminC = 15 }
            };
            foreach (var fruit in basket)
            {
               
                Console.WriteLine($"Type: {fruit.GetType().Name}");
                Console.WriteLine($"Price: {fruit.Price}");
                Console.WriteLine($"Sort: {fruit.Sort}");
                fruit.Taste();
                if (fruit is Apple apple)
                {
                    Console.WriteLine($"Vitamin A: {apple.VitaminA}");
                    Console.WriteLine($"Vitamin B: {apple.VitaminB}");
                }
                else if (fruit is Pineapple pineapple)
                {
                    Console.WriteLine($"Vitamin E: {pineapple.VitaminE}");
                    Console.WriteLine($"Vitamin D: {pineapple.VitaminD}");
                }
                else if (fruit is Orange orange)
                {
                    Console.WriteLine($"Vitamin C: {orange.VitaminC}");
                }

                Console.WriteLine("--------------------------------------------------");
            }
            
        }

    }
    abstract class Fruit
    {
        public decimal Price { get; set; }
        public string Sort { get; set; }


        public abstract void Taste();
    }
    class Apple : Fruit
    {
        public int VitaminA { get; set; }
        public int VitaminB { get; set; }


        public override void Taste()
        {
            Console.WriteLine("Apple has a sweet and slightly tart taste.");
        }
    }

    class Pineapple : Fruit
    {

        public int VitaminD { get; set; }
        public int VitaminE { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Pineapple has a sweet and tangy taste");
        }
    }
    class Orange : Fruit
    {
        public int VitaminC { get; set; }

        public override void Taste()
        {
            Console.WriteLine("Orange has a sweet and citrusy taste.");
        }
    }


}
