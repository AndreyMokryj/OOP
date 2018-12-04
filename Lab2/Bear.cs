using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Bear : Predator
    {
        public Bear(string n, int w) : base(n, w)
        {
        }

        public override string Voice()
        {
            if (!sleep)
                return "Bear " + name;
            else
                return "Z-z-z-z";
        }
    }
}
