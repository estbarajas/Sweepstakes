using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            ISweepstakesManager manager = SweepstakeManagerFactory.ChooseStackOrQueue();

            Sweepstakes sweepstake = new Sweepstakes(" Fortnite battlepass!");

            Contestant contestant = new Contestant();
            contestant.SetFirstName("Uma");
            contestant.SetLastName("Bob");
            contestant.SetEmailAdress("Uma@gmail.com");

            sweepstake.RegisterContestant(contestant);
            
            Contestant contestant2 = new Contestant();
            contestant2.SetFirstName("Joy");
            contestant2.SetLastName("Madden");
            contestant2.SetEmailAdress("Joy@gmail.com");

            sweepstake.RegisterContestant(contestant2);

            manager.InsertSweepstakes(sweepstake);

            MarketingFirm firm = new MarketingFirm(manager);

            Console.WriteLine(manager.GetSweepstakes().PickWinner());
            Console.ReadLine();
        }
    }
}
