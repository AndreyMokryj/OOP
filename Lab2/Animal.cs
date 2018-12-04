using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Animal
    {
        Guid id;
        public string name;
        public int weight;
        public bool sleep = false;

        public Animal(string n, int w)
        {
            id = Guid.NewGuid();
            name = n;
            weight = w;
        }

        public abstract string Voice();

        public void Sleep()
        {
            sleep = true;
        }

        public void WakeUp()
        {
            sleep = false;
        }
    }
}
