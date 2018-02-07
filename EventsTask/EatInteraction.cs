using System;

namespace EventsTask
{
    public class EatInteraction
    {
       public event EventHandler EatCycle = delegate {  };

        public virtual void OnEatCycle()
        {
            EatCycle?.Invoke(this, null);
        }
        
        
    }
}