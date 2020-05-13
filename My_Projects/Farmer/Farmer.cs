using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    class Farmer
    {
        // Used prop this generate template
        public int BagsOfFeed { get;  private set; }

        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        private int numberOfCows;

        public Farmer(int numberOfCows, int feedMultiplier)
        {
            NumberOfCows = numberOfCows;
            this.feedMultiplier = feedMultiplier;

        }
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
