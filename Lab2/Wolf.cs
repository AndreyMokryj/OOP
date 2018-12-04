using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Wolf : Predator
    {
        public Wolf(string n, int w) : base(n, w)
        {
        }

        public override string Voice()
        {
            if (!sleep)
                return "Wolf " + name;
            else
                return "Z-z-z-z";
        }
    }
}
