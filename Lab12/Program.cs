using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            int playcount = 0;
            int wincount = 0;
            int Papcount = 0;
            int Rockcount = 0;
            int Scissorcount = 0;

            do
            {
                Console.WriteLine("which player do you want face?");
                Console.WriteLine("1) Human ");
                Console.WriteLine("2) Stupid Computer ");
                Console.WriteLine("3) Random Computer ");

                Console.WriteLine("4) Hal (Smart Computer) ");

                int UserPick = Validate.RangeValidator(1, 4);

                Console.WriteLine("ok now choose: type 'rock', 'paper' or 'scissor'");

                string UserPlay = Validate.GetValidString();

                Console.WriteLine("=================================");

                //playcount Hal needs this

                
                
                switch (UserPick)
                {

                    case 1:
                        
                        Human bob = new Human();
                        Console.WriteLine("Player 2 choose 'rock','paper' or 'scissors' dont look at above this line");
                       
                        string Oplay = bob.GetRoshambo();
                       
                        if (Oplay == UserPlay)
                        {
                            Console.WriteLine("draw");
                        }
                        else if (Oplay == "scissors" && UserPlay == "rock")
                        {
                            Rockcount++;
                            Console.WriteLine("player 1 wins");
                        }
                        else if (Oplay == "scissors" && UserPlay == "paper")
                        {
                            Papcount++;
                            Console.WriteLine("player 2 wins");
                        }
                        else if (Oplay == "paper" && UserPlay == "scissors")
                        {
                            Scissorcount++;
                            Console.WriteLine("Player 1 wins");
                        }
                        else if (Oplay == "paper" && UserPlay == "rock")
                        {
                            Rockcount++;
                            Console.WriteLine("player 2 wins");
                        }
                        else if (Oplay == "rock" && UserPlay == "scissors")
                        {
                            Scissorcount++;
                            Console.WriteLine("player 2 wns");
                        }

                        else if (Oplay == "rock" && UserPlay == "paper")
                        {
                            Papcount++;
                            Console.WriteLine("player 1 wins");
                        }
                        break;

                    case 2:
                        RockPlayer DumbComp = new RockPlayer();
                        
                        Console.WriteLine(DumbComp.GetRoshambo());
                        if (UserPlay == "rock")
                        {
                            Console.WriteLine("draw");
                        }
                        else if (UserPlay == "scissors")
                        {
                            Console.WriteLine("you lose");
                        }
                        else
                        {
                            Console.WriteLine("you win");
                        }
                        break;

                    case 3:

                        RandomPlayer RanComp = new RandomPlayer();
                        string RanPlay = RanComp.GetRoshambo();
                        Console.WriteLine(RanPlay);

                        if (RanPlay == UserPlay)
                        {
                            Console.WriteLine("draw");
                        }
                        else if (RanPlay == "scissors" && UserPlay == "rock")
                        {
                            Console.WriteLine("you win");
                        }
                        else if (RanPlay == "scissors" && UserPlay == "paper")
                        {
                            Console.WriteLine("computer 2 wins");
                        }
                        else if (RanPlay == "paper" && UserPlay == "scissors")
                        {
                            Console.WriteLine("you win");
                        }
                        else if (RanPlay == "paper" && UserPlay == "rock")
                        {
                            Console.WriteLine("computer 2 wins");
                        }
                        else if (RanPlay == "rock" && UserPlay == "scissors")
                        {
                            Console.WriteLine("computer 2 wns");
                        }

                        else if (RanPlay == "rock" && UserPlay == "paper")
                        { Console.WriteLine("you win"); }                                            
                        break;

                    case 4:
                        

                        //Track userplays

                        if (UserPlay == "rock")
                        {
                            Rockcount++;
                        }
                        else if (UserPlay == "paper")
                        {
                            Papcount++;
                        }
                        else
                        {
                            Scissorcount++;
                        }

                        playcount++;

                        string HalsPlay = Hal.GetRoshambo(playcount, wincount, Rockcount, Papcount, Scissorcount);

                        if (HalsPlay == UserPlay)
                        {
                            Console.WriteLine("draw");
                        }
                        else if (HalsPlay == "scissors" && UserPlay == "rock")
                        {
                            wincount++;
                            Console.WriteLine("you win");
                        }
                        else if (HalsPlay == "scissors" && UserPlay == "paper")
                        {
                            Console.WriteLine("Hal wins");
                        }
                        else if (HalsPlay == "paper" && UserPlay == "scissors")
                        {
                            wincount++;
                            Console.WriteLine("you win");
                        }
                        else if (HalsPlay == "paper" && UserPlay == "rock")
                        {
                            Console.WriteLine("Hal wins");
                        }
                        else if (HalsPlay == "rock" && UserPlay == "scissors")
                        {
                            Console.WriteLine("Hal wins");
                        }

                        else if (HalsPlay == "rock" && UserPlay == "paper")
                        {
                            wincount++;
                            
                                Console.WriteLine("you win");
                            }
                        

                        break;

                }
                Console.WriteLine("===============================");
                Console.WriteLine("win count: " + wincount);
                Console.WriteLine("playcount: " + playcount);
                Console.WriteLine("Rockcount: " + Rockcount);
                Console.WriteLine("Papercount: " + Papcount);
                Console.WriteLine("Scissor: " + Scissorcount);

            } while (Validate.Continue());
            Console.WriteLine(playcount);
            
            }

        

       
    }
}
