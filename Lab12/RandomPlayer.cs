using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class RandomPlayer:Player
    {

        public override string GetRoshambo()
        {
            Random random = new Random();
            int pick = random.Next(1, 3);

            if (pick == 1)
            {
                return "paper";
            }
            else if (pick == 2)
            {
                return "scissors";
            }
            else
            {
                return "rock";
            }
                        
        }
    }
}
