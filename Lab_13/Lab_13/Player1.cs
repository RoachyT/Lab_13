using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Player1 : Player
    {

        public Player1(string name): base ( name)
        {

        }
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
