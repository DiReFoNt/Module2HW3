using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Dill : Stems, IHowToCook
    {
        public Dill()
        {
            Name = "Dill";
            AgeDays = 60;
            Form = "Umbrella";
            Color = "Green";
            HeightCm = 150;
            Specialty = "Does anyone notice me?";
            KCal = 43;
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
