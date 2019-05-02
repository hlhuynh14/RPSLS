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
            int number = random.Next(1, 6);

            string Choice = GetString(number);
            return Choice;
        }
        public string GetString(int number)
        {
            List<string> Rpsls = new List<string> { "rock", "paper", "scissor", "lizard", "spock" };
            int count = -1;
            foreach (string element in Rpsls)
            {
                if (number == count)
                {
                    count++;
                    return element;
                }
                else
                { continue;
                }
            }
            return null;
        }
    }
}
