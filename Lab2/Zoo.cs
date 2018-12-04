using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Zoo
    {
        public List<Animal> animals;        
        public List<Cage> cages;
        public List<Zone> zones = new List<Zone>();
        public bool night;

        public Zoo()
        {
            animals = new List<Animal>();
            cages = new List<Cage>();        
            night = false;
        }
        
        public void AddZone(Zone z)
        {
            zones.Add(z);
            z.zoo = this;
            foreach (Component c in z.Components())
            {
                if (c is Zone)
                    AddZone((Zone)c);
                else
                    cages.Add((Cage)c);
            }
        }              

        public void AddAnimal(string n, int w)
        {
            if (cages.Count > 0)
            {
                Creator c = new Creator();
                Animal animal = c.Create(n, w);                
                for (int j = 0; j < cages.Count - 1; j++)
                    cages[j].Successor = cages[j + 1];
                cages[0].AddAnimal(animal);
                animals.Add(animal);
            }
            else
                throw new NotEnoughPlaceException("Nowhere to place");           
        }

        public double SumWeight()
        {
            double sum = 0;
            foreach (Animal animal in animals)
                sum += animal.weight;
            return sum;
        }

        public double AwgWeight()
        {
            return SumWeight() / animals.Count();
        }

        public void Night()
        {
            foreach (Animal animal in animals)
                animal.Sleep();
            night = true;
        }

        public void Day()
        {
            foreach (Animal animal in animals)
                animal.WakeUp();
            night = false;
        }

        public void Voice()
        {
            foreach (Animal a in animals)
                Console.WriteLine(a.Voice());
        }
    }
}
