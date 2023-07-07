using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {




            int player = 0;
            int playerScore = 0;
            int computerScore = 0;
            int pcGlobalScore = 0;
            int playerGlobalScore = 0;
            int round = 1;
            bool keepGame = true;
            string endGame = "";
            string question = "";
            question = endGame;

            Random rand = new Random();
            int compRand = rand.Next(1, 4);


            Console.WriteLine("-------Game-------");
            Console.WriteLine("Rock - Paper - Scissors");
            Console.Write("Select How Many Round Do You Want ? ");
            int roundInput = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");
            Console.Write("Enter numbers >>>1(Rock) 2(Paper) 3(Scissors)<<< : ");
            player = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------");



            while (keepGame)
            {

                compRand = rand.Next(1, 4);


                if (player == 1)
                {
                    Console.WriteLine("You used : Rock");
                }
                else if (player == 2)
                {
                    Console.WriteLine("You used : Paper");
                }
                else if (player == 3)
                {
                    Console.WriteLine("You used : Scissors");
                }

                if (compRand == 1)
                {
                    Console.WriteLine("Pc used : Rock");
                }
                else if (compRand == 2)
                {
                    Console.WriteLine("Pc used : Paper");
                }
                else if (compRand == 3)
                {
                    Console.WriteLine("Pc used : Scissors");
                }


                if (compRand == 1 && player == 3 || compRand == 2 && player == 1 || compRand == 3 && player == 2)
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine("Computer won!");
                    computerScore++;
                    Console.WriteLine("Computer score is : " + computerScore);
                }
                else if (player == 1 && compRand == 3 || player == 2 && compRand == 1 || player == 3 && compRand == 2)
                {
                    Console.WriteLine("-------------");
                    Console.WriteLine("Player won!");
                    playerScore++;
                    Console.WriteLine("Player score is : " + playerScore);
                }
                else if (player == 1 && compRand == 1 || player == 2 && compRand == 2 || player == 3 && compRand == 3)
                {
                    Console.WriteLine("Draw");
                }
                else
                {
                    Console.WriteLine("Please enter corect input");
                }


                if (round == roundInput)
                {
                    Console.WriteLine("---------------");
                    Console.WriteLine("The game is over");
                    Console.WriteLine("---------------");
                    Console.WriteLine("Your score is : " + playerScore);
                    Console.WriteLine("---------------");
                    Console.WriteLine("Pc score is : " + computerScore);
                    Console.WriteLine("---------------");
                    if (playerScore > computerScore)
                    {
                        Console.WriteLine("The player won the game");
                        playerGlobalScore++;
                        Console.WriteLine("Your Global score is : " + playerGlobalScore);
                        Console.WriteLine("PC global score is : " + pcGlobalScore);
                    }
                    else if (playerScore == computerScore)
                    {
                        Console.WriteLine("The game ended in a draw");
                        Console.WriteLine("Your Global score is : " + playerGlobalScore);
                        Console.WriteLine("--------------");
                        Console.WriteLine("PC global score is : " + pcGlobalScore);
                        Console.WriteLine("--------------");
                    }
                    else
                    {
                        Console.WriteLine("The computer won the game");
                        pcGlobalScore++;
                        Console.WriteLine("PC global score is : " + pcGlobalScore);
                        Console.WriteLine("Your Global score is : " + playerGlobalScore);
                        Console.WriteLine("--------------");
                    }
                    Console.Write("Do you want to play again yes or no ? : ");
                    question = Console.ReadLine();

                    
                    if (question == "yes")
                    {
                        keepGame = true;
                        playerScore = 0;
                        computerScore = 0;
                        round = 0;                     
                    }
                    else if (question == "no")
                    {
                        keepGame = false;
                        Console.WriteLine("Good bay  < -_- >");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input");
                        break;
                    }
                }

                round++;
                Console.WriteLine("---------------");
                Console.Write("It's yor turn >>>1(Rock) 2(Paper) 3(Scissors)<<< : ");
                player = int.Parse(Console.ReadLine());

            }







        }
    }
}
