using System;

using tester = System.Console;


namespace usings
{
    class Program
    {


        static void Main(string[] args)
        {
            EventsArgstruct ev = new EventsArgstruct();
            FlatsEvents Fe = new FlatsEvents(ev);
            HomesEvents He = new HomesEvents(ev);
            ev.saparate();




        }
    }
}
