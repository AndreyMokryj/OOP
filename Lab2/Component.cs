using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Component
    {
        public Zoo zoo;
        public Component()
        {
            //zoo = z;
            //number = n;
        }

        public virtual void Add(Component component) { }
        public virtual void Remove(Component component) { }
    }
}
