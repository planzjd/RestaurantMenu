using System;
using System.IO;

namespace Studio18_RestaurantMenue_Project
{
    public class Menu
    {
        public string FoodCatagories { get; set; }
        public Menu(string afood)
        {
            FoodCatagories = afood;
        }
        public static string GetTimeStamp(DateTime value)
        {
            return value.ToString("yyyy/MM/dd/HHmm");
        }


        //new food item

    }
}
