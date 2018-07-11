using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<string> mySweepstakesQueue;
        public SweepstakesQueueManager()
        {
            mySweepstakesQueue = new Queue<string>();
        }

        public Sweepstakes GetSweepstakes()
        {
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            throw new NotImplementedException();
        }
    }
}
