using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameStarter
    {   // member variables (HAS A)
        public List<string> RockList;
        public List<string> PaperList;
        public List<string> ScissorList;
        public List<string> LizardList;
        public List<string> SpockList;
        //public int counter;
        //public int OpponentCounter;
        public Player Player1;
        public Player Player2;
        



        // constructor
        public GameStarter()
        {
            RockList = new List<string> {"lizard", "scissor", "rock", "paper", "spock"};
            PaperList = new List<string> {"spock", "rock", "paper", "scissor", "lizard"};
            ScissorList = new List<string> {"paper", "lizard", "scissor", "spock", "rock"};
            LizardList = new List<string> {"spock", "paper", "lizard", "scissor", "rock"};
            SpockList = new List<string> {"rock", "scissor", "spock", "paper", "lizard"};
           
        }

        // member methods (CAN DO)

        public void ScoreCheck()
        {

            while (Player1.score < 3 && Player2.score < 3) 
            { Console.WriteLine($"Current score is {Player1.score} to {Player2.score}.");
                string Gamer1Choice = ValidityCheck(Player1.GetChoice());
                Console.WriteLine($"Player1 plays {Gamer1Choice}");
               string Gamer2Choice = ValidityCheck(Player2.GetChoice());
                Console.WriteLine($"Player2 plays {Gamer2Choice}");


                if (FindWhoWon(Gamer1Choice, Gamer2Choice) > 0)
                {
                    Player1.score++;
                }
                else if (FindWhoWon(Gamer1Choice, Gamer2Choice) < 0)
                {
                    Player2.score++;
                }
                else
                {
                    ScoreCheck();

                }
            }
            DisplayWinner();
        }
        public void NumbersOfPlayers()
        {
            Console.WriteLine("Please enter amount of human players playing, choose between 1 and 2.");
            int Players = int.Parse(Console.ReadLine());
            CreatePlayers(Players);
        }


        public void CreatePlayers(int number)
        {
            if (number == 2)
            {
                Player1 = new Human();
                Player2 = new Human();
            }
            else if (number == 1)
            {
                Player1 = new Human();
                Player2 = new Ai();
            }
            else
            {
                Console.WriteLine("Not an option");
                NumbersOfPlayers();
            }

        }
        Double FindWhoWon(string Player1Choice, string Player2Choice)                                                                                          
        {
            switch (Player1Choice)
            {
                case "rock":
                    {
                        int Player1Point = 2;
                        int Player2Point = RockList.IndexOf(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                case "paper":
                    {
                        int Player1Point = 2;
                        int Player2Point = PaperList.IndexOf(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                case "scissor":
                    {
                        int Player1Point = 2;
                        int Player2Point = ScissorList.IndexOf(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                case "lizard":
                    {
                        int Player1Point = 2;
                        int Player2Point = LizardList.IndexOf(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                case "spock":
                    {
                        int Player1Point = 2;
                        int Player2Point = SpockList.IndexOf(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                default:
                    {
                        return 0;
                    }

            }
        }
        public void DisplayWinner()
        {
            if (Player1.score == 3)
            {
                Console.WriteLine("Player 1 won the game!");



            }
            else
            {
                Console.WriteLine("Player 2 won the game!");

            }
        }
        public string PlayAgain()
        {
            Console.WriteLine("Enter yes to play again!");
            string answer = Console.ReadLine();


            if (answer == "yes")
            {
                return "yes";

            }
            else
            {

                return "no";
            }
        }
        public string ValidityCheck(string check)
        {
            if (check == "rock")
            {
                return check;
            }
            else if (check == "paper")
            {
                return check;
            }
            else if (check == "lizard")
            {
                return check;
            }
            else if (check == "spock")
            {
                return check;
            }
            else if (check == "scissor")
            {
                return check;
            }
            else
            {
                Console.WriteLine("That's not an option.");
                return Player1.GetChoice();
            }
        }
        public void ShowRules()
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
        }
    }
}
