﻿using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class GroomingScheduler
    {
        private static GroomingScheduler instance;

        public static GroomingScheduler Instance => instance ?? (instance = new GroomingScheduler());

        private GroomingScheduler()
        {
        }

        public void AssignGroomingJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    if (animal is AnimalThatCanBeGroomed groomableAnimal)
                    {
                        keeper.GroomAnimal(groomableAnimal);
                    }
                }
            }
        }
    }
}