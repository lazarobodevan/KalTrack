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

        public Food() { }
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

        public override string ToString()
        {
            return "Nome: " + Name
              + "\n Marca: " + Brand
              + "\n Carboidrados: " + Carb
              + "\n Proteinas: " + Prot
              + "\n Gorduras: " + Fat
              + "\n --> Calorias: " + calcKal();
        }



    }
}
