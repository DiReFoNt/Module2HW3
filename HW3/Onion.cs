using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Onion : Bulbs, IHowToCook
    {
        public Onion()
        {
            Name = "Onion";
            AgeDays = 50;
            Form = "Circular";
            Color = "Nutmeg";
            HeightCm = 70;
            Specialty = "I make you want to cry.";
            KCal = 40;
        }

        public override void Grow()
        {
            Console.WriteLine($"I grow {AgeDays} days, my height {HeightCm} cm");
        }

        public string HowCook()
        {
            return "Peel me from the husk and slice me";
        }
    }
}
