using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Zone z1 = new Zone();
            Zone z2 = new Zone();
            BearCage bc = new BearCage( 10);
            GiraffeCage gc = new GiraffeCage( 10);
            WolfCage wc = new WolfCage( 10);
            
            z1.Add(z2);
            z1.Add(bc);
            z2.Add(gc);
            z2.Add(wc);
            zoo.AddZone(z1);
            
            zoo.AddAnimal("Alex", 100);
            zoo.AddAnimal("Ben", 220);
            zoo.AddAnimal("Max", 350);
            zoo.AddAnimal("Alex", 140);
            zoo.AddAnimal("Nick", 400);
            zoo.AddAnimal("Marty", 228);
            zoo.AddAnimal("David", 100);
            zoo.AddAnimal("Nick", 321);
            zoo.AddAnimal("Max", 234);
            zoo.AddAnimal("Ben", 400);
            Console.WriteLine("Sum. weight = " + zoo.SumWeight());
            Console.WriteLine("Awg. weight = " + zoo.AwgWeight());

            Console.WriteLine("\nDay, voice:");
            zoo.Voice();
            zoo.Night();
            Console.WriteLine("\nNight, voice:");
            zoo.animals[0].WakeUp();
            zoo.animals[5].WakeUp();
            zoo.Voice();


            Console.ReadLine();
        }
    }
}
