using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                GameStarter NewGame = new GameStarter();
                NewGame.NumbersOfPlayers();
                NewGame.ScoreCheck();
               string answer = NewGame.PlayAgain();

            }
            while (answer == "yes");
            {
                Console.WriteLine("Welcome to Rock, Paper, Scissor, Lizard, Spock!");
                Console.WriteLine("You take turn picking gestures, if you gesture is better than the other player, you win that round.");
                Console.WriteLine("Best out of 5!");
                Console.WriteLine("Rock crushes Scissors");
                Console.WriteLine("Scissors cuts Paper");
                Console.WriteLine("Paper covers Rock");
                Console.WriteLine("Rock crushes Lizard");
                Console.WriteLine("Lizard poisons Spock");
                Console.WriteLine("Spock smashes Scissors");
                Console.WriteLine("Scissors decapitates Lizard");
                Console.WriteLine("Paper disproves Spock");
                Console.WriteLine("Spock vaporizes Rock");

                GameStarter NewGame = new GameStarter();
                NewGame.NumbersOfPlayers();
                NewGame.ScoreCheck();
            }
        }

    }
}
