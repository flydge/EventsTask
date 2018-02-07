using System;
using System.Globalization;

namespace EventsTask
{
    internal class Program
    {
        
        public static void Main(string[] args)
        {
            Plant plant = new Plant();
            Herbivore herbivore = new Herbivore();
            Carnivore carnivore = new Carnivore();
            
            
            
            EatInteraction eatInteraction = new EatInteraction();
            eatInteraction.EatCycle += (sender, e) =>
            {
                if (plant.ReadyForEat == false)
                {
                    plant.Growth();
                }
            };
            eatInteraction.EatCycle += (sender, e) =>
            {
                if (plant.ReadyForEat)
                {
                    herbivore.EatPlant();
                }
                else
                {
                    Console.WriteLine("Plant is not grown");
                }
            };
            eatInteraction.EatCycle += (sender, e) =>
            {
                if (carnivore.Hyngry)
                {
                    carnivore.EatHerbivore();
                }
                else
                {
                    Console.WriteLine("Carnivore is not hungry");
                }
            };
            eatInteraction.OnEatCycle();

        }
      
    }
}