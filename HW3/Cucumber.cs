using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Cucumber : RipeFruit, IHowToCook
    {
        public Cucumber()
        {
            Name = "Cucumber";
            AgeDays = 50;
            Form = "Cylindrical";
            Color = "Green";
            HeightCm = 17;
            Specialty = "Making salad and cocktails fresher.";
            KCal = 16;
        }

        public override void Grow()
        {
            Console.WriteLine($"I grow {AgeDays} days, my height {HeightCm} cm");
        }

        public string HowCook()
        {
            return "Peel the skins and cut into pieces";
        }
    }
}
