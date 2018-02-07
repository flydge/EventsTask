using System;
using System.Threading;

namespace EventsTask
{
    public class Plant
    {
        private Boolean _readyForEat;
        private int _growthTime = 10;

        public Plant(bool readyForEat = false)
        {
            _readyForEat = readyForEat;
        }

        public bool ReadyForEat => _readyForEat;

        public void Growth()
        {
           
            for (int i = _growthTime - 1; i >= 0; i--)
            {
                Console.Write("Growth started:\ntime until the end of growth:");
                Console.WriteLine(i);
                Thread.Sleep(1000);
                Console.Clear();
            }
            _readyForEat = true;
            Console.WriteLine("Plant is grown.");
        }
    }
}