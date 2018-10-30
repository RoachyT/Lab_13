using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    abstract class Player
    {
        public string Name { get; set; }
        public Roshambo RoshamboValue { get; set; }
         public Player(string name)
           {
            Name = name;
        
           }
        abstract public Roshambo GenerateRoshambo();
        
        
    }
}
