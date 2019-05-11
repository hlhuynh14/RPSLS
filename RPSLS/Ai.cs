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

            string Choice = GetString(number);
            return Choice;
        }
        private string GetString(int number)
        {
            List<string> Rpsls = new List<string> { "rock", "paper", "scissor", "lizard", "spock" };
            int count = 0;
            foreach (string element in Rpsls)
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
