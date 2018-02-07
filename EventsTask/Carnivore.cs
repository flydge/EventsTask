using System;
using System.Threading;

namespace EventsTask
{
    public class Carnivore
    {
        private Boolean _hyngry;

        public Carnivore(bool hyngry = true)
        {
            _hyngry = hyngry;
        }

        public bool Hyngry => _hyngry;

        public void EatHerbivore()
        {
            Thread.Sleep(1000);
            _hyngry = false;
            Console.WriteLine("Carnivore has eaten a Herbivore.");
        }
    }
}