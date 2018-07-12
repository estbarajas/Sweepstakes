using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
     static class SweepstakeManagerFactory 
    {
        public static ISweepstakesManager ChooseStackOrQueue()
        {
            ISweepstakesManager chosenManager = null;
            string stackOrQueue;
            Console.WriteLine("What manager to use? \na) stack \nb) queue");
            stackOrQueue = Console.ReadLine();
            switch (stackOrQueue.ToLower())
            {
                case "a":
                    SweepstakesStackManager stackManager = new SweepstakesStackManager();
                    chosenManager = stackManager;
                    break;
                case "b":
                    SweepstakesQueueManager queueManager = new SweepstakesQueueManager();
                    chosenManager = queueManager;
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            return chosenManager;
        }
    }
}
