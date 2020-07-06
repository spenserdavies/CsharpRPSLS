using System;
using System.Collections.Generic;
using System.Threading;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rock Paper BitchSlap";
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            bool playing = false;
            Console.Clear();

            Random rand = new Random();
            Dictionary<string, string> moves = new Dictionary<string, string>(){
                {"rock", ""},
                {"paper", ""},
                {"scissors", ""},
                {"lizard", ""},
                {"spock", ""},
            };
            Console.WriteLine("Hi! My name is Jakes Mom.");
            Console.WriteLine("\nWhats Your Name?");
            Console.WriteLine("");
            string name = Console.ReadLine();
            string lowerName = name.ToLower();
            playing = true;
            if(lowerName =="droids"){
                Console.Clear();
                Console.WriteLine("We Dont Serve Your Kind");
                Console.WriteLine(@"         
                             .-.
                            /_ _\
                            |o^o|
                            \ _ /
                           .-'-'-.
                         /`)  .  (`\
                        / /|.-'-.|\ \
                        \ \| (_) |/ /  .-``-.
                         \_\'-.-'/_/  /[] _ _\
                         /_/ \_/ \_\ _|_o_LII|_
                           |'._.'|  / | ==== | \
                           |  |  |  |_| ==== |_|
                            \_|_/    ||' ||  ||
                            |-|-|    ||LI  o ||
                            |_|_|    ||'----'||
---------------------------/_/ \_\  /__|    |__\-------------
               ----------#########################-----------");
                Thread.Sleep(6000);
                playing = false;
            }

            int wins = 0;
            int loses = 0;
            int ties = 0;

            Console.Clear();
            #region //Hi, lets play....
            Console.WriteLine($"\nHi {name}!");
            while (playing)
            {
            Console.WriteLine("\nLets Play Rock-Paper-Scissors-Lizard-Spock..");
            #endregion
                #region //Choose....
                Console.WriteLine("\n ");
                Console.WriteLine("          -----------------------------------");
                Console.WriteLine("         |                                   |");
                Console.WriteLine("         | C H O O S E Y O U R F I G H T E R |");
                Console.WriteLine("         |                                   |");
                Console.WriteLine("          -----------------------------------");
                Console.WriteLine("         |   rock   |   paper   |  scissors  |");
                Console.WriteLine("          -----------------------------------");
                Console.WriteLine("         |     lizard     |       spock      |");
                Console.WriteLine("          -----------------------------------");
                Console.WriteLine("         | you chose:                        |");
                Console.WriteLine("          -----------------------------------");
                Console.WriteLine("\n ");
                Console.SetCursorPosition(23, 15);

                Console.ForegroundColor = ConsoleColor.White;
                string choice = Console.ReadLine().ToLower();
                Console.ForegroundColor = ConsoleColor.Black;
                #endregion
                if (moves.ContainsKey(choice))
                {
                    var cpuMove = rand.Next(1, 6);
                    string cpuHand = "";
                    switch (cpuMove)
                    {
                        case 1:
                            cpuHand = "rock";
                            break;
                        case 2:
                            cpuHand = "paper";
                            break;
                        case 3:
                            cpuHand = "scissors";
                            break;
                        case 4:
                            cpuHand = "lizard";
                            break;
                        case 5:
                            cpuHand = "spock";
                            break;
                        default:
                            break;
                    }
                    Console.Clear();
                    Console.WriteLine("----------------------------------------");
                    Console.WriteLine($"\n  You Chose {choice}! And I chose {cpuHand}");
                    Console.WriteLine("\n----------------------------------------");
                        #region //W-L switch statement

                    switch (choice + cpuHand)
                    {
                        case "rockscissors":
                        case "rocklizard":
                        case "paperrock":
                        case "paperspock":
                        case "scissorspaper":
                        case "scissorslizard":
                        case "lizardspock":
                        case "lizardpaper":
                        case "spockscissors":
                        case "spockrock":
                            Console.WriteLine($"\nYou Won you dirty cheater. {choice} beats {cpuHand}....");
                            wins++;
                            Console.WriteLine($"\nYou Have Won {wins} times, Lost {loses} times, and Tied {ties} times");
                            break;
                        case "rockpaper":
                        case "rockspock":
                        case "paperscissors":
                        case "paperlizard":
                        case "scissorsrock":
                        case "scissorsspock":
                        case "spockpaper":
                        case "spocklizard":
                        case "lizardscissors":
                        case "lizardrock":
                            Console.WriteLine($"\nHA loser I win! {cpuHand} beats {choice}!");
                            loses++;
                            Console.WriteLine($"\nYou Have Won {wins} times, Lost {loses} times, and Tied {ties} times");
                            break;
                        case "rockrock":
                        case "paperpaper":
                        case "scissorsscissors":
                        case "spockspock":
                        case "lizardlizard":
                            Console.WriteLine("\nOK We tied but like, I still win");
                            ties++;
                            Console.WriteLine($"\nYou Have Won {wins} times, Lost {loses} times, and Tied {ties} times");
                            break;
                        default:
                            break;
                    }
                        #endregion

                    Console.WriteLine("\nContinue? (y/n)");
                    char response = Console.ReadKey().KeyChar;
                    if (response == 'n')
                    {
                        playing = false;
                    }
                    else if(response == 'y'){
                    Console.Clear();
                    Console.WriteLine($"\n{wins} wins, {loses} loses, {ties} ties");
                    } else {
                        Console.Clear();
                        Console.WriteLine("youre gonna play again anyway");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\nInvalid Selection, Please Try Again");
                }
            }
            Console.Clear();
            Console.WriteLine($"You suck {name}");
            Console.WriteLine($"\nYour Final Score is W:{wins} L:{loses} T:{ties}");
            Thread.Sleep(2000);
            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine(@"\(owo\)");
                Thread.Sleep(300);
                Console.Clear();
                Console.WriteLine(" ");
                Console.WriteLine(@" (/owo)/");
                Thread.Sleep(300);
            }
            Console.Clear();
            Console.WriteLine("w00t");
        }
    }
}
