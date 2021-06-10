using System;

namespace Master
{
    class Program
    {
        static void Main(string[] args)
        {
            Colleague1 colleague1 = new Colleague1();
            Colleague2 colleague2 = new Colleague2();
            new ConcreteMediator(colleague1, colleague2);

            Console.WriteLine("Client triggets operation A.");
            colleague1.ActionColleague1();    


        }
    }

}
