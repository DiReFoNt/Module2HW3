using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Garlic : Bulbs, IHowToCook
    {
        public Garlic()
        {
            Name = "Garlic";
            AgeDays = 28;
            Form = "Circular";
            Color = "White";
            HeightCm = 120;
            Specialty = "Saving you from vampires.";
            KCal = 149;
        }

        public override void Grow()
        {
            Console.WriteLine($"I grow {AgeDays} days, my height {HeightCm} cm");
        }

        public string HowCook()
        {
            return "Split me up into slices and press them down";
        }
    }
}
