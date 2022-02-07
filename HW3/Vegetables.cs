using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Vegetables : Plants, IComparable
    {
        public string Name { get; protected set; }
        public string Form { get; protected set; }
        public string Color { get; protected set; }
        public string Specialty { get; protected set; }
        public double AgeDays { get; protected set; }
        public double HeightCm { get; protected set; }
        public double KCal { get; protected set; }
        public bool PresenceFetus
        {
            get { return false; }
            protected set { }
        }

        public int CompareTo(object obj)
        {
            Vegetables v = obj as Vegetables;
            if (v != null)
            {
                if (KCal < v.KCal)
                {
                    return -1;
                }
                else if (KCal > v.KCal)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new Exception("Are these vegetables for sure?");
            }
        }

        public virtual void Grow()
        {
        }
    }
}
