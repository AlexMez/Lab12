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

            do
            {
                Console.WriteLine("which player do you want face?");
                Console.WriteLine("1) Human ");
                Console.WriteLine("2) Stupid Computer ");
                Console.WriteLine("3) Random Computer ");

                int UserPick = Validate.RangeValidator(1, 3);

                Console.WriteLine("ok now choose: type 'rock', 'paper' or 'scissor'");

                string UserPlay = Validate.GetValidString();

                Console.WriteLine("=================================");

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
                            Console.WriteLine("player 1 wins");
                        }
                        else if (Oplay == "scissors" && UserPlay == "paper")
                        {
                            Console.WriteLine("player 2 wins");
                        }
                        else if (Oplay == "paper" && UserPlay == "scissors")
                        {
                            Console.WriteLine("Player 1 wins");
                        }
                        else if (Oplay == "paper" && UserPlay == "rock")
                        {
                            Console.WriteLine("player 2 wins");
                        }
                        else if (Oplay == "rock" && UserPlay == "scissors")
                        {
                            Console.WriteLine("player 2 wns");
                        }

                        else if (Oplay == "rock" && UserPlay == "paper")
                            Console.WriteLine("player 1 wins");
                        
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
                            Console.WriteLine("computer 1 wins");
                        }
                        else if (RanPlay == "scissors" && UserPlay == "paper")
                        {
                            Console.WriteLine("computer 2 wins");
                        }
                        else if (RanPlay == "paper" && UserPlay == "scissors")
                        {
                            Console.WriteLine("computer 1 wins");
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
                            Console.WriteLine("computer 1 wins");

                        break;
                }


            } while (Validate.Continue());

            
            }
        }
    }
