using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Parsley : Stems, IHowToCook
    {
        public Parsley()
        {
            Name = "Parsley";
            AgeDays = 20;
            Form = "Umbrella";
            Color = "Black-Green";
            HeightCm = 50;
            Specialty = "I have a rejuvenating effect";
            KCal = 36;
        }

        public override void Grow()
        {
            Console.WriteLine($"I grow {AgeDays} days, my height {HeightCm} cm");
        }

        public string HowCook()
        {
            return "Just rinse and slice me";
        }
    }
}
