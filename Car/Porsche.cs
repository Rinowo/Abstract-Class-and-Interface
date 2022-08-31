using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Porsche :ICar, IEletricCar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }
        public string Star()
        { return "Engine start"; }
        public string Stop()
        {
            return "Break!";
        }
        public Porsche(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public override string ToString()
        {
            return Color + " Tesla " + Model + " with " + Battery + " Batteries" + Star() + "\n" + Stop();
        }
    }
}
