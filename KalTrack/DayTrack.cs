using System;
using System.Collections.Generic;
using System.Text;

namespace KalTrack
{
    class DayTrack{
        private List<Meal> _meals;
        public DateTime day { get; set; }


        public DayTrack() { 

        }


        public double totalKalMeal(){
            double amount = 0;
            foreach (Meal x in _meals){
                foreach (Food y in x.foods){
                    amount += y.calcKal();
                }
            }
            return amount;
        }

        public void isAmountEnough(){
            double qtdKal = totalKalMeal();
            int calorias = 2460; //TMB (1583) * 1,55 --> pessoal
            if (qtdKal > calorias)
            {
                Console.WriteLine("Acima da quantidade necessária!");
                Console.WriteLine("Necessárias: " + calorias);
                Console.WriteLine("Consumidas: " + qtdKal);

            }
            else if (qtdKal == calorias || qtdKal == calorias)
            {
                Console.WriteLine("Quantidade exata de calorias!");
                Console.WriteLine("Necessárias: " + calorias);
                Console.WriteLine("Consumidas: " + qtdKal);
            }
            else
            {
                Console.WriteLine("Quantidade abaixo da necessária!");
                Console.WriteLine("Necessárias: " + calorias);
                Console.WriteLine("Consumidas: " + qtdKal);
            }
        }
    }
}
