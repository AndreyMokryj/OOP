using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Tests
{
    [TestClass()]
    public class ProgramTests
    {        
        Zoo zoo = new Zoo();
        Zone zone1 = new Zone();
        Zone zone2 = new Zone();
                
        BearCage bearCage3place = new BearCage(3);
        GiraffeCage giraffeCage3place = new GiraffeCage(3);
        WolfCage wolfCage3place = new WolfCage(3);

        [TestMethod()]
        public void ZoneAddTest()
        {            
            zone1.Add(zone2);
            zoo.AddZone(zone1);            
            
            Assert.AreEqual(zoo.zones[0], zone1);
            Assert.AreEqual(zoo.zones[1], zone2);
        }

        [TestMethod()]
        public void ComponentHirerarchyTest()
        {
            zone1.Add(zone2);
            zone1.Add(bearCage3place);
            zone2.Add(giraffeCage3place);
            zone2.Add(wolfCage3place);
            zoo.AddZone(zone1);

            Assert.AreEqual(zone1.Components()[0], zone2);
            Assert.AreEqual(zone1.Components()[1], bearCage3place);
            Assert.AreEqual(zone2.Components()[0], giraffeCage3place);
            Assert.AreEqual(zone2.Components()[1], wolfCage3place);

        }

        [TestMethod()]
        [ExpectedException(typeof(NotEnoughPlaceException))]
        public void NoCagesTest()
        {
            Zoo zoo = new Zoo();            
            zoo.AddAnimal("Alex", 100);            
        }

        [TestMethod()]
        [ExpectedException(typeof(NotEnoughPlaceException))]
        public void NoPlaceTest()
        {
            zone1.Add(zone2);
            zone1.Add(bearCage3place);
            zone2.Add(giraffeCage3place);
            zone2.Add(wolfCage3place);
            zoo.AddZone(zone1);
            for (int i = 0; i < 10; i++)
                zoo.AddAnimal("Alex", 100);            
        }
        
        [TestMethod()]
        public void SumWeightTest()
        {                                      
            zone1.Add(zone2);
            zone1.Add(bearCage3place);
            zone2.Add(giraffeCage3place);
            zone2.Add(wolfCage3place);
            zoo.AddZone(zone1);  

            zoo.AddAnimal("Alex", 10);
            zoo.AddAnimal("Ben", 20);
            zoo.AddAnimal("Max", 30);
            
            Assert.AreEqual(zoo.SumWeight(), 60);               
        }

        [TestMethod()]
        public void AwgWeightTest()
        {            
            zone1.Add(zone2);
            zone1.Add(bearCage3place);
            zone2.Add(giraffeCage3place);
            zone2.Add(wolfCage3place);
            zoo.AddZone(zone1);

            zoo.AddAnimal("Alex", 10);
            zoo.AddAnimal("Ben", 20);
            zoo.AddAnimal("Max", 30);
            
            Assert.AreEqual(zoo.AwgWeight(), 20);
        }

        [TestMethod()]
        public void VoiceTest()
        {            
            zone1.Add(zone2);
            zone1.Add(bearCage3place);
            zone2.Add(giraffeCage3place);
            zone2.Add(wolfCage3place);
            zoo.AddZone(zone1);

            zoo.AddAnimal("Alex", 100);            
            Animal a = zoo.animals[0];
            string v1 = a.Voice();

            zoo.Night();
            string v2 = a.Voice();
            Assert.AreEqual(v2, "Z-z-z-z");
            a.WakeUp();
            Assert.AreEqual(a.Voice(), v1);
        }
    }
}