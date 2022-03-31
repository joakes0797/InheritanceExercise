using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
        public Bird()
        {
            Name = "";
            MakesNoise = "";
            LegCount = 2;
            CanSwim = false;
        }


        public bool CanFly { get; set; }
        public string FeatherColor { get; set; }
        public bool BlueEgg { get; set; }
        public string Characteristic { get; set; }

    }
}
