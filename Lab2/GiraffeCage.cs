using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class GiraffeCage : Cage
    {
        public GiraffeCage( int nm) : base( nm)
        {
        }

        public override void AddAnimal(Animal animal)
        {
            if (nmax > nf && animal is Giraffe)
            {
                nf++;
                animals.Add(animal);
            }
            else if (Successor != null)
                Successor.AddAnimal(animal);
            else
                throw new NotEnoughPlaceException("Not enough place!!!");
        }

        public override void RemoveAnimal(Animal animal)
        {
            animals.Remove(animal);
        }
    }
}
