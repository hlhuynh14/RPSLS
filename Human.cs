using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Human : Player
    {
        // member variables (HAS A)



        // constructor
     

        // member methods (CAN DO)
        public override string GetChoice()
        {
            Console.WriteLine("What will you play? Options are rock, paper, scissor, lizard, or spock.");
            string Choice = Console.ReadLine();
            return Choice;
        }
    }
}
