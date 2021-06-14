using System;

namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayStack = new Stack<string>();
            arrayStack.Push("First element");
            arrayStack.Push("Second element");
            arrayStack.Push("Third element");

            Console.WriteLine(arrayStack.Peek());

            arrayStack.Pop();
            arrayStack.Push("Last element");

            Console.WriteLine(arrayStack.Peek());
        }
    }
}
