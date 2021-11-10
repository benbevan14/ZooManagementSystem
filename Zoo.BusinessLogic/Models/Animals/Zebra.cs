using System;
using Zoo.BusinessLogic.Helpers;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Zebra : AnimalThatCanBeGroomed, IMuckSweeping
    {
        public Zebra(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public void Sweep()
        {
            SweepingHelper.Sweep();
        }
    }
}