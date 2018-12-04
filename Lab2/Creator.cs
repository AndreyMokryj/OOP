using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Creator
    {        
        public Animal Create(string n, int w)
        {
            Random rnd = new Random();
            int i = rnd.Next(5);
            if (i == 4)            
                return new Giraffe(n, w);            
            else if (i % 2 == 0)
                return new Bear(n, w);
            else
                return new Wolf(n, w);
        }
    }
}
