using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main()
        {
            string answer;

            GameStarter NewGame = new GameStarter();
            NewGame.ShowRules();
            NewGame.NumbersOfPlayers();
            NewGame.ScoreCheck();
            answer = NewGame.PlayAgain();

            if ( answer == "yes") { 
            Main();
            }
            else
            {
                Console.WriteLine("See You Again!");
                Console.ReadLine();
            }



        }

    }
}
