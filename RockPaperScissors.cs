using System;

namespace actualrockpaperscissors
{
    class Program
    {
        static int Randcomputerchoice()
        {
            Random rnd = new Random();
            int computernumchoice = rnd.Next(0, 2);
            return computernumchoice;
        }
        //Rock:0,Paper:1,Scissors:2
        // Nine combinations for the game
        static int Userwon(string user,string computerchoice)
        {
            int winner=0;
            if (user=="R"&&computerchoice=="S")
            {
             winner = 1;
            }
            else if (user == "R" && computerchoice == "P")
            {
                winner = 2;
            }
            if (user == "P" && computerchoice == "S")
            {
                winner = 3;
            }
            else if (user == "P" && computerchoice == "R")
            {
                winner = 4;
            }
            else if (user == "S" && computerchoice == "P")
            {
                winner = 5;
            }
            else if (user == "S" && computerchoice == "R")
            {
                winner = 6;
            }
            if (user == computerchoice)
            {
                winner = 7;
            }
              return winner;
        }
        static void Main(string[] args)
        {
            
            string userchoice = "",compchoice="";
            int userwins=0,computerwins=0;
           
            do
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("Rock:R,Paper:P,Scissors:S");
                
                Console.WriteLine("Wins: "+userwins+" Loses: "+computerwins);
                Console.Write("Choose: ");
                
                
                userchoice = Console.ReadLine();
                if (userchoice != "R" && userchoice != "P" && userchoice != "S")
                {
                    Console.WriteLine("Incorrect answer");
                    Console.WriteLine("************************************************");
                }
                int comnum = Randcomputerchoice();

                if (comnum == 0)
                {
                    compchoice = "R";
                }
                else if (comnum == 1)
                {
                    compchoice = "P";
                }
                else if (comnum == 2)
                {
                    compchoice = "S";
                }

                int winner = Userwon(userchoice, compchoice);

                if (winner == 1)
                {
                    userwins++;
                }
                else if (winner == 2)
                {
                    computerwins++;
                }
                else if (winner == 3)
                {
                    computerwins++;
                }
                else if (winner == 4)
                {
                    userwins++;
                }
                else if (winner == 5)
                {
                    userwins++;
                }
                else if (winner == 6)
                {
                    computerwins++;
                }
                else if (winner == 7)
                {
                   Console.WriteLine("Draw");
                }
                string Thewinner = "";
                if (winner == 1 || winner == 4 || winner == 5)
                {
                    Thewinner = "User WINS!";
                }
                else if (winner == 7)
                {
                    Thewinner = "Nobody Wins";
                }
                else{
                    Thewinner = "Computer WINS!";

                }
                Console.WriteLine("Winner: "+Thewinner );


            } while (userchoice != "z");
           
        }
    }
}
