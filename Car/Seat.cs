﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    internal class Seat :ICar
    {
        public string Model { get; set; }
        public string Color { get; set; }
        public string Star()
        { return "Engine start"; }
        public string Stop()
        {
            return "Breaaak!";
        }
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public override string ToString()
        {
            return Color + " Seat " + Model + Star() + "\n\n" + Stop();
        }
    }
}
