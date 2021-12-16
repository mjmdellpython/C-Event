namespace usings
{
    public class FlatsEvents
    {
        private EventsArgstruct _Ea;

        public FlatsEvents(EventsArgstruct  Ea)
        {
            this._Ea = Ea;
            Ea.TestDEevent += Flatresult;
        }

        public void Flatresult()
        {
            System.Console.WriteLine( "This is Flat");
        }


    }
}