using System;

namespace Master
{
    public class Colleague1 : BaseColleague
    {
        public Colleague1()
        {
            
        }
        public void ActionColleague1()
        {
            Console.WriteLine("Colleague 1 done some acthion. Colleague 2 can start!");
            this._mediator.Notify(this, "Colleague 1 complete!");
        }
    }

}
