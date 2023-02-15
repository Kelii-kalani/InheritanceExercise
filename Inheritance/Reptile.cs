using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public string Type { get; set; }
        public bool IsNocturnal { get; set; }
        public string EcoSystem { get; set; }
        public bool Scales { get; set; }
        public bool Herbivore { get; set; }
    }
}
