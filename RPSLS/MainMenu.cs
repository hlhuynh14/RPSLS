using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class GameStarter
    {   // member variables (HAS A)
        public List<string> rockList;
        public List<string> paperList;
        public List<string> scissorList;
        public List<string> lizardList;
        public List<string> spockList;
        //public int counter;
        //public int OpponentCounter;
        public Player player1;
        public Player player2;
        



        // constructor
        public GameStarter()
        {
            rockList = new List<string> {"lizard", "scissor", "rock", "paper", "spock"};
            paperList = new List<string> {"spock", "rock", "paper", "scissor", "lizard"};
            scissorList = new List<string> {"paper", "lizard", "scissor", "spock", "rock"};
            lizardList = new List<string> {"spock", "paper", "lizard", "scissor", "rock"};
            spockList = new List<string> {"rock", "scissor", "spock", "paper", "lizard"};
           
        }

        // member methods (CAN DO)

        public void PlayGame()
        {

            while (player1.score < 3 &&player2.score < 3) 
            { Console.WriteLine($"Current score is {player1.score} to {player2.score}.");
                string Gamer1Choice = CheckValidity(player1.GetChoice());
                Console.WriteLine($"Player1 plays {Gamer1Choice}");
               string Gamer2Choice = CheckValidity(player2.GetChoice());
                Console.WriteLine($"Player2 plays {Gamer2Choice}");


                if (FindWhoWon(Gamer1Choice, Gamer2Choice) > 0)
                {
                    player1.score++;
                }
                else if (FindWhoWon(Gamer1Choice, Gamer2Choice) < 0)
                {
                    player2.score++;
                }
                else
                {
                    PlayGame();

                }
            }
            DisplayWinner();
        }
        public void DetermineNumbersOfPlayers()
        {   
            Console.WriteLine("Please enter amount of human players playing, choose between 1 and 2.");
            int number;
            string value = Console.ReadLine();
            if (Int32.TryParse(value, out number) == false)
            {
                Console.WriteLine("Not an option");
                DetermineNumbersOfPlayers();
            }
            else
            {
                number = int.Parse(value);
            }
            CreatePlayers(number);
        }


        public void CreatePlayers(int number)
        {
           
            if (number == 2)
            {
                player1 = new Human();
                player2 = new Human();
            }
            else if (number == 1)
            {
                player1 = new Human();
                player2 = new Ai();
            }

            else
            {
                Console.WriteLine("Not an option");
                DetermineNumbersOfPlayers();
            }

        }
        Double FindWhoWon(string player1Choice, string player2Choice)                                                                                          
        {
            switch (player1Choice)
            {
                case "rock":
                    {
                        int player1Point = 2;
                        int player2Point = rockList.IndexOf(player2Choice);
                        int total = player1Point - player2Point;
                        return total;
                    }
                case "paper":
                    {
                        int player1Point = 2;
                        int player2Point = paperList.IndexOf(player2Choice);
                        int total = player1Point - player2Point;
                        return total;
                    }
                case "scissor":
                    {
                        int player1Point = 2;
                        int player2Point = scissorList.IndexOf(player2Choice);
                        int total = player1Point - player2Point;
                        return total;
                    }
                case "lizard":
                    {
                        int player1Point = 2;
                        int player2Point = lizardList.IndexOf(player2Choice);
                        int total = player1Point - player2Point;
                        return total;
                    }
                case "spock":
                    {
                        int player1Point = 2;
                        int player2Point = spockList.IndexOf(player2Choice);
                        int total = player1Point - player2Point;
                        return total;
                    }
                default:
                    {
                        return 0;
                    }

            }
        }
        public void DisplayWinner()
        {
            if (player1.score == 3)
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
        public string CheckValidity(string check)
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
                return player1.GetChoice();
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
