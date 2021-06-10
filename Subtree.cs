using System;
using System.Collections.Generic;

namespace Master
{
    public class Subtree : Component
    {
        public Subtree(string name) 
            : base(name)
        {

        }
        List<Component> livingOrganisms = new List<Component>();
        public override void Add(Component component)
        {
            livingOrganisms.Add(component);
        }
        public override void Remove(Component component)
        {
            livingOrganisms.Remove(component);
        }
        public override void Print()
        {
            Console.WriteLine(name);
            //foreach(Component component in livingOrganisms)
            //{
            //    Console.WriteLine(component);
            //}
            foreach (Component component in livingOrganisms)
            {
                component.Print();
            }
        }
    }
}
