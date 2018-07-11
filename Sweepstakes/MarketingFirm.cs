using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm : IChooseStackOrQueue
    {
        ISweepstakesManager sweepstakesManager;
        public MarketingFirm(ISweepstakesManager sweepstakesManager)
        {
            this.sweepstakesManager = sweepstakesManager;
        }

        public void ChooseStackOrQueue(Sweepstakes sweepstake)
        {
            string stackOrQueue;
            stackOrQueue = Console.ReadLine();
            switch (stackOrQueue.ToLower())
            {
                case "stack":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();
                    stackManager.InsertSweepstakes(sweepstake);
                    break;
                case "queue":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    queueManager.InsertSweepstakes(sweepstake);
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }           
        }
    }
}
