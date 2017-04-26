using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Hal
    {
        public static string GetRoshambo(int play, int win, int roc, int pap, int scis)
        {

            //counters the first move

            if (play == 1 && win == 1 && roc == 1)
            {
                return "paper";
            }
            else if (play == 1 && win == 1 && pap == 1)
            {
                return "scissors";
            }
            else if (play == 1 && win == 1 && scis == 1)
            {
                return "rock";
            }
            
            else if (play == 1 && win == 0 && roc == 1)
            {
               return "scissors";
            }

            else if (play == 1 && win == 0 && pap == 1)
            {
                return "rock";
            }

            else if (play == 1 && win == 0 && scis == 1)
            {
                return "paper";
            }


            else
            {
                return DefaultPlay();
            }

            
            
            
        }

        public static string DefaultPlay()
        {
            Random random2 = new Random();
            int pick = random2.Next(1, 3);

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
