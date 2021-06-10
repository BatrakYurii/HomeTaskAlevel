using System;

namespace Master
{
    public class Colleague2 : BaseColleague
    {
        public Colleague2()
        {

        }
        public void ActionColleague2()
        {
            Console.WriteLine("Colleague 2 done some acthion.");
            this._mediator.Notify(this, "Colleague 2 comlete!");
        }
    }

}
