using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> registeredContestants;
        public string sweepstakeName;
        public int runningTotal;
        public string Name
        {
            get
            {
                return sweepstakeName;
            }
        }
        public Sweepstakes(string name)
        {
            registeredContestants = new Dictionary<int, Contestant>();
            sweepstakeName = name;
        }

        public void RegisterContestant(Contestant contestant)
        {
            registeredContestants.Add(contestant.registrationNumber = runningTotal,contestant);
            runningTotal++;
        }

        public string PickWinner()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, registeredContestants.Count);
            return "Winner: " + registeredContestants[randomNumber].firstName + " " + registeredContestants[randomNumber].lastName + " won" + " the"+ sweepstakeName; 
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.firstName + " " + contestant.lastName + " " + contestant.registrationNumber);
        }
    }
}
