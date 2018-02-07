using System;
using System.Threading;

namespace EventsTask
{
    public class Herbivore
    {
        private Boolean _hyngry;

        public Herbivore(bool hyngry = true)
        {
            _hyngry = hyngry;
        }

        public bool Hyngry => _hyngry;

        public void EatPlant()
        {
            Thread.Sleep(1000);
            _hyngry = false;
            Console.WriteLine("Herbivore has eaten a plant");
        }
    }
}