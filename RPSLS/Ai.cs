using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Ai : Player
    {
        // member variables (HAS A)



        // constructor


        // member methods (CAN DO)




        public override string GetChoice()
        { Random random = new Random();
            int number = random.Next(0, 5);

            string choice = GetString(number);
            return choice;
        }
        private string GetString(int number)
        {
            List<string> rpsls = new List<string> { "rock", "paper", "scissor", "lizard", "spock" };
            int count = 0;
            foreach (string element in rpsls)
            {
                if (number == count)
                {
                    
                    return element;
                }
                else
                {
                    count++;
                }
            }
            return null;
        }
    }
}
