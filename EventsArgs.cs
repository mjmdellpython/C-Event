namespace usings
{
    public class EventsArgstruct
    {
        public delegate void DEvents();
        public event DEvents TestDEevent;

        public void saparate()
        {
            TestDEevent?.Invoke();
        }

    }
}