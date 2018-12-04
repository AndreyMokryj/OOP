using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Zone : Component
    {
        public Zoo parent;
        private List<Component> components = new List<Component>();
        public List<Component> Components()
        {
            return components;
        }

        public Zone() : base()
        {
        }

        public override void Add(Component component)
        {
            components.Add(component);
            component.zoo = this.zoo;
            if (zoo != null)
                if (!zoo.zones.Contains(component) && component is Zone)
                    zoo.AddZone((Zone)component);
            
            
        }

        public override void Remove(Component component)
        {
            components.Remove(component);
        }
    }
}
