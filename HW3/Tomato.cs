using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Tomato : RipeFruit, IHowToCook
    {
        public Tomato()
        {
            Name = "Tomato";
            AgeDays = 50;
            Form = "Circular";
            Color = "Red";
            HeightCm = 70;
            Specialty = "I smell pizza.";
            KCal = 24;
        }

        public override void Grow()
        {
            Console.WriteLine($"I grow {AgeDays} days, my height {HeightCm} cm");
        }

        public string HowCook()
        {
            return "Rinse me and slice me into circles";
        }
    }
}
