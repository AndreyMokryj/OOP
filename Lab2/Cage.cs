using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Cage : Component
    {
        public int nmax, nf;
        public List<Animal> animals = new List<Animal>();
        public Cage(int nm) : base()
        {
            nmax = nm;
            nf = 0;
        }

        public Cage Successor;
        public abstract void AddAnimal(Animal animal);
        public abstract void RemoveAnimal(Animal animal);
    }
}
