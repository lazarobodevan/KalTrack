using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace KalTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            Food food = new Food();
            List<Food> foods = new List<Food>();
            //FoodControl fc = new FoodControl();
            FoodControl.InsertFood(foods, food);
        }
        }
    }
