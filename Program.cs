using System;

namespace Master
{
    public class Program
    {
        static void Main(string[] args)
        {
            var h = new HashTable<int, string>();
            h.Add(33, "First element");
            h.Add(44, "Second element");
            h.Add(33, "Third element");

            Console.WriteLine(h.Find(33));

            h.Remove(33);
            h.ContainsValue("cond element");
        }
    }
}
