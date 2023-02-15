using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Bird : Animal
    {
        public string Breed { get; set; }
        public string Size { get; set; }
        public bool DoesItFly { get; set; }
        public bool SwimsInWater { get; set; }
        public bool BirdOfPrey { get; set; }
    }
}
