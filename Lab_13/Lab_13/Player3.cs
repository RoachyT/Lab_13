using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Player3: Player
    {

        public Player3(string name) : base(name)
        {

        }
        public override Roshambo  GenerateRoshambo() { return Roshambo.Scissors; }
        public  Roshambo GenerateRoshambo(string input)
        {
            if (input == "R")
            {
                return Roshambo.Rock;
            }
            else if (input == "P")
            {
                return Roshambo.Paper;
            }
            else 
            {
                return Roshambo.Scissors;
            }
        }
    }
}
