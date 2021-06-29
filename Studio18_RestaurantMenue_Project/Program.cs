using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

namespace Studio18_RestaurantMenue_Project
{
    class Program
    {

        static Menu appetizers = new Menu("Appetizers");
        static Menu mainCourse = new Menu("Main Course");
        static Menu dessert = new Menu("Dessert");
        static Menu newItems = new Menu("**Brand New Selection**");

        static MenuItem jalapeno = new MenuItem("Jalapeno poppers", "Jalapenos stuffed with cheese and fried.", 10);
        static MenuItem stuffedPeppers = new MenuItem("Stuffed Peppers", "Peppers stuffed with ground beef, rice and cheese.", 8);
        static MenuItem tacosCarneAsada = new MenuItem("Tacos Carne Asada ", "Marinated sirloin grilled to perfection. Comes with tortillas, Pico de Gallo, rice, and beans.", 10);
        static MenuItem torta = new MenuItem("Torta", "Chopped grilled marinated sirloin on our famous torta bread. Comes with guacamole and Pico de Gallo.", 8);
        static MenuItem friedIceCream = new MenuItem("Fried Ice Cream", "Encrusted fried ice cream", 5);

        //static Regex rgx = new Regex("[^a-zA-Z]");


        private static string Rgx(string input)
        {
            string user = input.Trim();
          //  user = rgx.Replace(user, "").ToLower();
            return user;
        }

        static void NewItem()
        {
            Console.WriteLine("Would you like to add an item to the menu?");
            string food;
            string foodDesc;
            double foodPrice;
            string input = Console.ReadLine().Trim();
            string user = Rgx(input);

            if (user == "yes")
            {
                Console.WriteLine("What is the new item you would like to add?");
                input = Console.ReadLine().Trim();
                food = Rgx(input);
                Console.WriteLine("What is the new item's description?");
                input = Console.ReadLine().Trim();
                foodDesc = Rgx(input);
                Console.WriteLine("What is the new item's price?");
                input = Console.ReadLine().Trim();
                foodPrice = Double.Parse(input);

                MenuItem newItem = new MenuItem(food, foodDesc, foodPrice);
                PrintMenu();
                Console.WriteLine(newItems.FoodCatagories);
                Console.WriteLine($"{ food }\n{ foodDesc}\nPrice: ${ foodPrice}\n");
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("\tTacos 'n More");
            Console.WriteLine(appetizers.FoodCatagories);
            Console.WriteLine($"{jalapeno.Food}\n{jalapeno.FoodDescription}\nPrice: ${jalapeno.FoodPrice}\n");
            Console.WriteLine($"{stuffedPeppers.Food}\n{stuffedPeppers.FoodDescription}\nPrice: ${stuffedPeppers.FoodPrice}\n");
            Console.WriteLine(mainCourse.FoodCatagories);
            Console.WriteLine($"{tacosCarneAsada.Food}\n{tacosCarneAsada.FoodDescription}\nPrice: ${tacosCarneAsada.FoodPrice}\n");
            Console.WriteLine($"{torta.Food}\n{torta.FoodDescription}\nPrice: ${torta.FoodPrice}\n");
            Console.WriteLine(dessert.FoodCatagories);
            Console.WriteLine($"{friedIceCream.Food}\n{friedIceCream.FoodDescription}\nPrice: ${friedIceCream.FoodPrice}\n");
        }

        static void Main(string[] args)
        {
            PrintMenu();
            NewItem();
        }
    }
}
