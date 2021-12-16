namespace usings
{
    public class HomesEvents
    {
        private EventsArgstruct _Ea;

        public HomesEvents(EventsArgstruct Ea)
        {
            this._Ea = Ea;
            Ea.TestDEevent += HomesResults;
        }

        public void HomesResults()
        {
            System.Console.WriteLine(   "It is Homes ");
        }
    }
}