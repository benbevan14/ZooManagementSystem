using System.Collections.Generic;
using Zoo.BusinessLogic.Models;
using Zoo.BusinessLogic.Models.Animals;

namespace Zoo.BusinessLogic.Services
{
    public class MuckingScheduler
    {
        private static MuckingScheduler instance;

        public static MuckingScheduler Instance => instance ?? (instance = new MuckingScheduler());

        private MuckingScheduler()
        {
        }

        public void AssignMuckingJobs(IEnumerable<Keeper> keepers, IEnumerable<Animal> animals)
        {
            foreach (var keeper in keepers)
            {
                foreach (var animal in keeper.GetResponsibleAnimals())
                {
                    if (animal is IMuckSweeping sweepable)
                    {
                        sweepable.Sweep();
                    }
                }
            }
        }
    }
}