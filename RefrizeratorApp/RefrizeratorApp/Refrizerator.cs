using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrizeratorApp
{
    internal class Refrizerator
    {
        public double MaxWeight { set; get; }
        public double CurrentWeight { private set; get; }
        public double RemainingWeight { private set; get; }

        public Refrizerator(double maxWeight)
        {
            MaxWeight = maxWeight;
        }

        public void AddItems(int noOfItems, double weightPerUnit)
        {
            double weightToBeAdded = noOfItems*weightPerUnit;
            if (CurrentWeight + weightToBeAdded <= MaxWeight)
            {
                CurrentWeight += weightToBeAdded;
                RemainingWeight = MaxWeight - CurrentWeight;
            }
            else
            {
                throw new Exception();
            }
        }
}
}
