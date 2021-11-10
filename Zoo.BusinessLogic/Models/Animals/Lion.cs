using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.BusinessLogic.Helpers;

namespace Zoo.BusinessLogic.Models.Animals
{
    public class Lion : Animal, IMuckSweeping
    {
        public Lion(DateTime dateOfBirth) : base(dateOfBirth)
        {
        }

        public void Sweep()
        {
            SweepingHelper.Sweep();
        }
    }
}