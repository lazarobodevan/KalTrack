using System;
using System.Collections.Generic;
using System.Globalization;

namespace KalTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static void InsertFood<Food>(List<Food> foods, Food food){
            int opt;
            string name, brand;
            double carb, prot, fat;
            Console.Write("Inserir varios alimentos (1) ou apenas um (2)? :");
            opt = int.Parse(Console.ReadLine());

            if (opt == 1){
                Console.WriteLine("Para sair, entre com um espaço no nome do alimento!");
                while (true){
                    Console.Write("Nome: ");
                    name = Console.ReadLine();
                    if(name == " "){
                        return;
                    }
                    Console.Write("Marca: ");
                    brand = Console.ReadLine();
                    Console.WriteLine("Carboidratos: ");
                    carb = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Proteinas: ");
                    prot = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.WriteLine("Gorduras: ");
                    fat = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    food = new Food(name, brand, carb, prot, fat);

                }
            }
        }

        }
    }
