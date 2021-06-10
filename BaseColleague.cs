namespace Master
{
    public class BaseColleague
    {
        protected IMediator _mediator;

        public BaseColleague(IMediator mediator = null)
        {
            this._mediator = mediator;
        }
        public void SetMediator(IMediator mediator)
        {
            this._mediator = mediator;
        }
    }

}
