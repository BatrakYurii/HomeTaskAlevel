using System;

namespace Master
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Component animals = new Subtree("animals");

            Component mammals = new Subtree("mammals");
            animals.Add(mammals);

            Component whale = new Leaf("whale");
            mammals.Add(whale);

            Component insects = new Leaf("insects");
            animals.Add(insects);

            animals.Print();

            Console.WriteLine("---------------------");

            mammals.Print();


        }
    }
}
