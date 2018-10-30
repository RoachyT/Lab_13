using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Player2 : Player
    {
        
        public Player2(string name) : base(name)
        {

        }
        public override Roshambo GenerateRoshambo()
        {
            Random Random = new Random();
            int gen = Random.Next(1, 4);
            if (gen == 1)
            {
                return Roshambo.Paper;
            }
            else if (gen == 2)
            {
                return Roshambo.Rock;
            }
           else 
            {
                return Roshambo.Scissors;
            }  
        }
    }
}
