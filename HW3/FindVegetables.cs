using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal static class FindVegetables
    {
        public static Vegetables[] KcalMoreNum(this Vegetables[] v, int number)
        {
            Vegetables[] newV = new Vegetables[v.Length];
            int index = 0;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i].KCal > number)
                {
                    newV[index] = v[i];
                    ++index;
                }
            }

            newV = newV.Where(x => x != null).ToArray();
            return newV;
        }
    }
}
