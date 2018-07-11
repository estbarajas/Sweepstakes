using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> mySweepstakesQueue;
        public SweepstakesQueueManager()
        {
            mySweepstakesQueue = new Queue<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            return mySweepstakesQueue.Dequeue();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            mySweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}
