using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_13
{
    class Program
    {
        static int winCount = 0;
        static int tieCount = 0;
       static int lossCount = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Player3 User = new Player3(userName);
            GameON(User);
            
        }

       static void GameON(Player3 User)
        {
            try
            {
            Player1 Bowser = new Player1("Bowser");
            Player2 PrincessPeach = new Player2("Princess Peach");
            Console.WriteLine("Who would you like to play against? Bowser(1) or Princess Peach(2)?");
            Console.WriteLine("Press 1 or 2");
            int inputOpp = int.Parse(Console.ReadLine());
            Console.WriteLine("Rock, Paper or Scissors? R/P/S?");
            string shoot = (Console.ReadLine().ToUpper());
                
                Validator Val = new Validator();
                bool flag = true;
                flag = Val.Validation(shoot);
                while (flag)
                {
          
                    if (inputOpp == 1)
                    {
                        Roshambo opponent = Bowser.GenerateRoshambo();
                        Roshambo user = User.GenerateRoshambo(shoot);
                        Console.WriteLine($"Bowser: {opponent}");
                        Console.WriteLine($"{User.Name}: {user}");
                        if (opponent == Roshambo.Rock && user == Roshambo.Rock)
                        {
                            Console.WriteLine("Draw!");
                            tieCount++;
                            PlayAgain(User);

                        }
                        if (opponent == Roshambo.Rock && user == Roshambo.Paper)
                        {
                            Console.WriteLine($"{User.Name} wins!");
                            winCount++;
                            PlayAgain(User);
                        }
                        if (opponent == Roshambo.Rock && user == Roshambo.Scissors)
                        {
                            Console.WriteLine($"Bowser wins!");
                            lossCount++;
                            PlayAgain(User);
                        }

                    }
                    else if (inputOpp == 2)
                    {
                        Roshambo opponent = PrincessPeach.GenerateRoshambo();
                        Roshambo user = User.GenerateRoshambo(shoot);
                        Console.WriteLine($"Princess Peach: {opponent}");
                        Console.WriteLine($"{User.Name}: {user}");
                        if (opponent == Roshambo.Rock && user == Roshambo.Rock || opponent == Roshambo.Paper && user == Roshambo.Paper || opponent == Roshambo.Scissors && user == Roshambo.Scissors)
                        {
                            Console.WriteLine("Draw!");
                            tieCount++;
                            PlayAgain(User);
                        }
                        else if (opponent == Roshambo.Rock && user == Roshambo.Paper || opponent == Roshambo.Paper && user == Roshambo.Scissors || opponent == Roshambo.Scissors && user == Roshambo.Rock)
                        {
                            Console.WriteLine($"{User.Name} wins!");
                            winCount++;
                            PlayAgain(User);
                        }
                        else
                        {
                            Console.WriteLine($"Princess Peach wins!");
                            lossCount++;
                            PlayAgain(User);
                        }
                    }
                    else
                    {
                        Console.WriteLine("That was nonsense, try again");
                        PlayAgain(User);

                    }
                }
                Console.WriteLine("Try again");
                GameON(User);
            }
            catch (FormatException)
            {

                Console.WriteLine("That was incorrect");
                GameON(User);
            }

        }
        static void PlayAgain(Player3 User)
        {
            Console.WriteLine("Do you want to play again? y/n");
            string playAgain = Console.ReadLine().ToLower();
            if (playAgain == "yes" || playAgain == "y")
            {
                GameON(User);
            }
            else if (playAgain == "no" || playAgain == "n")
            {
                Console.WriteLine($"You won {winCount} times, lost {lossCount} times and tied {tieCount} times.");
                Console.WriteLine("GoodBye");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("HUH?");
                PlayAgain(User);
            }
        }
    }
}
