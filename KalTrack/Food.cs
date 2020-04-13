using System;
using System.Collections.Generic;
using System.Text;

namespace KalTrack
{
    class Food
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public double Carb { get; set; }
        public double Prot { get; set; }
        public double Fat { get; set; }
        public DateTime Hour { get; set; }

        public Food()
        {

        }

        public Food(string name, string brand, double carb, double prot, double fat)
        {
            this.Name = name;
            this.Brand = brand;
            this.Carb = carb;
            this.Prot = prot;
            this.Fat = fat;
        }

        public double calcKal() {
            return Carb * 4 + Prot * 4 + Fat * 9;
        }

        public void isAmountEnough(int qtdKal) { 
            if(calcKal() > (qtdKal+100)){
                Console.WriteLine("Acima da quantidade necessária!");

            }else if(calcKal() == (qtdKal+100) || calcKal() == (qtdKal-100)){
                Console.WriteLine("Quantidade exata de calorias");
            }
            else {
                Console.WriteLine("Quantidade abaixo da necessária");
            }
        }

    }
}
