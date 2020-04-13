using System;
using System.Collections.Generic;
using System.Globalization;

namespace KalTrack
{
    class FoodControl
    {
        public FoodControl() {

        }
        public static void InsertFood(List<Food> foods, Food food)
        {
            int opt;
            string name, brand;
            double carb, prot, fat;

            Console.Write("Inserir varios alimentos (1) ou apenas um (2)? :");
            opt = int.Parse(Console.ReadLine());

            if (opt == 1)
            {
                Console.WriteLine("Para sair, entre com um espaço no nome do alimento!");

                while (true)
                {
                    Console.Write("Nome: ");
                    name = Console.ReadLine();
                    if (name == " ")
                    {
                        break;
                    }

                    Console.Write("Marca: ");
                    brand = Console.ReadLine();

                    Console.Write("Carboidratos: ");
                    carb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Proteinas: ");
                    prot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Gorduras: ");
                    fat = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    food = new Food(name, brand, carb, prot, fat);

                    foods.Add(food);

                    Console.WriteLine("Alimento inserido com sucesso!");


                }
            }
            else
            {
                Console.Write("Nome: ");
                name = Console.ReadLine();

                Console.Write("Marca: ");
                brand = Console.ReadLine();

                Console.Write("Carboidratos: ");
                carb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Proteinas: ");
                prot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Gorduras: ");
                fat = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                food = new Food(name, brand, carb, prot, fat);

                foods.Add(food);

                Console.WriteLine("Alimento inserido com sucesso!");
                Console.WriteLine("--------------------------------");
                foreach (Food x in foods)
                {
                    Console.WriteLine(x.ToString());
                }
                return;
            }

            Console.WriteLine("--------------------------------");

            foreach (Food x in foods)
            {
                Console.WriteLine(x.ToString());
            }
        }
    }
}
