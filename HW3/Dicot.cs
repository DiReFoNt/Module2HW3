using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Dicot : Vegetables
    {
        public int NumberSeeds
        {
            get { return 2; }
            protected set { }
        }

        public override void Grow()
        {
            Console.WriteLine("I grow from 2 seed");
        }
    }
}
