using System;
using System.Collections.Generic;
using System.Text;

namespace KalTrack
{
    class Meal{
        public List<Food> foods;
        public string Kind;
        public DateTime Hour;

        public Meal(List<Food> foods, string kind) {
            this.foods = foods;
            this.Kind = kind;
            this.Hour = DateTime.Now;
        }


    }
}
