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
        public int counter;
        public int OpponentCounter;
        public Player Player1;
        public Player Player2;
        public GameStarter NewGame;
        
        

        // constructor
        public GameStarter()
        {
            RockList = new List<string> {"lizard", "scissor", "rock", "paper", "spock"};
            PaperList = new List<string> {"spock", "rock", "paper", "scissor", "lizard"};
            ScissorList = new List<string> {"paper", "lizard", "scissor", "spock", "rock"};
            LizardList = new List<string> {"spock", "paper", "lizard", "scissor", "rock"};
            SpockList = new List<string> {"rock", "scissor", "spock", "paper", "lizard"};
            counter = 0;
            OpponentCounter = 0;
           
        }

        // member methods (CAN DO)

        public void ScoreCheck()
        {

            while (counter != 3 && OpponentCounter != 3) 
            { Console.WriteLine($"Current score is {counter} to {OpponentCounter}.");
                string Gamer1Choice = Player1.GetChoice();
                Console.WriteLine($"Player1 plays {Gamer1Choice}");
               string Gamer2Choice = Player2.GetChoice();
                Console.WriteLine($"Player2 plays {Gamer2Choice}");


                if (FindWhoWon(Gamer1Choice, Gamer2Choice) > 0)
                {
                    counter++;
                }
                else if (FindWhoWon(Gamer1Choice, Gamer2Choice) < 0)
                { OpponentCounter++;
                }
                else
                {
                    ScoreCheck();

                }
            }
        }
        public void NumbersOfPlayers()
        {
            Console.WriteLine("Please enter amount of human players playing, choose between 0 and 2.");
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
            else if (number == 0)
            {
                Player1 = new Ai();
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
                        int Player2Point = RockList.BinarySearch(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        Console.WriteLine(Player2Point);
                        Console.WriteLine(Player2Choice);
                        return Total;
                    }
                case "paper":
                    {
                        int Player1Point = 2;
                        int Player2Point = PaperList.BinarySearch(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                case "scissor":
                    {
                        int Player1Point = 2;
                        int Player2Point = ScissorList.BinarySearch(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                case "lizard":
                    {
                        int Player1Point = 2;
                        int Player2Point = LizardList.BinarySearch(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                case "spock":
                    {
                        int Player1Point = 2;
                        int Player2Point = SpockList.BinarySearch(Player2Choice);
                        int Total = Player1Point - Player2Point;
                        return Total;
                    }
                default:
                    {
                        Console.WriteLine(" That wasn't an option.");
                        return 0;
                    }

            }
        }
        public void DisplayWinner()
        {
            if (counter == 3)
            {
                Console.WriteLine("Player 1 won the game!");
                Console.WriteLine("Enter yes to play again!");
                Console.ReadLine();
                string answer = Console.ReadLine();
                PlayAgain(answer);

            }
            else
            {
                Console.WriteLine("Player 2 won the game!");
                Console.WriteLine("Enter yes to play again!");
                string answer = Console.ReadLine();
                PlayAgain(answer);
            }
        }
        public void PlayAgain(string answer)
        {
            if (answer == "yes")
            {
                NewGame = new GameStarter();
                NewGame.ScoreCheck();
            }

            else
            {
                Console.WriteLine("See You Again!");
                Console.ReadLine();

            }
        }
    }
}
