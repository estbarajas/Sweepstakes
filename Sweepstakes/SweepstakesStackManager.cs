using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> mySweepstakesStack;
        public SweepstakesStackManager()
        {
            mySweepstakesStack = new Stack<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            return mySweepstakesStack.Pop();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            mySweepstakesStack.Push(sweepstakes);
        }
    }
}
