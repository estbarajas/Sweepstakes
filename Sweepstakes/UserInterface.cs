using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class UserInterface
    {
        public string stackOrQueue;
        ISweepstakesManager stackOrQueueChosen;
        public ISweepstakesManager StackOrQueue()
        {
            Console.WriteLine("Do you want to use stack or queue?");
            stackOrQueue = Console.ReadLine();
            switch (stackOrQueue.ToLower())
            {
                case "stack":
                    //stackOrQueueChosen =;
                    break;
                case "queue":
                    break;
                default:
                    Console.WriteLine("Invalid input.");
                    break;
            }
            return stackOrQueueChosen;
        }
    }
}
