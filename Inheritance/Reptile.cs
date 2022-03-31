using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            Name = "";
            MakesNoise = "";
            LegCount = 4;
            CanSwim = true;
        }

        public string FoodPreference { get; set; }
        public string PoweredBy { get; set; }
        public bool ForkedTongue { get; set; }
        public bool HasShell { get; set; } 




    }
}
