using System;

namespace Master
{
    public class Leaf : Component
    {
        public Leaf(string name)
            : base (name)
        {
            
        }
        public override void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public override void Remove(Component component)
        {
            throw new NotImplementedException();
        }
        public override void Print()
        {
            Console.WriteLine(name);
        }
    }
}
