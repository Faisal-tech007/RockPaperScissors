// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


namespace ROCKPAPERSCISSORS
{
    class program
    {
        static void Main(String[] args)
        {
            string intputPlayer, inputCPU;
            int randomInt;
           
            bool playAgain = true;

            while (true)
            {
                int scorePlayer = 0;
                int scoreCPU = 0;


                while (scorePlayer < 3 && scoreCPU < 3)
                {


                    Console.Write("Choose between Rock, Paper and Scissors:   ");
                    intputPlayer = Console.ReadLine();

                    intputPlayer = intputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer Choose Rock");
                            if (intputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (intputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (intputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer Choose Papper");
                            if (intputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (intputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (intputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            Console.WriteLine("Computer Choose Scissors");
                            if (intputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (intputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                scorePlayer++;
                            }
                            else if (intputPlayer == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
                }
                if (scorePlayer == 3)
                {
                    Console.WriteLine("PLAYER WON");
                }
                else if (scorePlayer == 3)
                {
                    Console.WriteLine("CPU WON");
                }
                else
                {

                }
                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();   
                if(loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {

                    playAgain = false;
                }
                else
                {

                }
            }

        }
    }
}