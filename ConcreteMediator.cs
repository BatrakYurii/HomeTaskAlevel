using System;

namespace Master
{
    public class ConcreteMediator : IMediator 
    {
        private Colleague1 _colleague1;

        private Colleague2 _colleague2;
        public ConcreteMediator(Colleague1 colleague1, Colleague2 colleague2)
        {
            _colleague1 = colleague1;
            _colleague1.SetMediator(this);
            _colleague2 = colleague2;
            _colleague2.SetMediator(this);
        }
        public void Notify(object sender, string ev)
        {
            if (ev == "Colleague 1 complete!")
            {
                Console.WriteLine("Mediator reacts on Colleague1");
                _colleague2.ActionColleague2();
            }
            if(ev == "Colleague 2 comlete!")
            {
                Console.WriteLine("Mediator reacts on Colleague2");

            }

        }
    }

}
