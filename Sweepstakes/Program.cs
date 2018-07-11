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
            Contestant contestant = new Contestant();
            contestant.SetFirstName("Joe");
            contestant.SetLastName("Smith");
            contestant.SetEmailAdress("Joe@gmail.com");

            Sweepstakes sweepstake = new Sweepstakes("Win $1005!");
            sweepstake.RegisterContestant(contestant);

            //Console.WriteLine(sweepstake.PickWinner());
            //Console.ReadLine();

            MarketingFirm marketingFirm = new MarketingFirm();
        }
    }
}
