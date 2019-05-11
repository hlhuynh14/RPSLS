using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    abstract class Player
    {
        // member variables (HAS A)
        public int score;

        // constructor
        public Player()
        {
            score = 0;

        }

        // member methods (CAN DO)
        abstract public string GetChoice();




    }
}
